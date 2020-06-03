using System;
using System.Collections.Generic;
using System.Net;
using DOGobj.DomainObjects;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using DOGobj.InfrastructureServices.Gateways.Database;

namespace DOGobj.ApplicationServices.Synchronization
{
    public class DOGobj_Cell
    {
        public int global_id { get; set; }
        public int Number { get; set; }
        public DOGobj_inf Cells { get; set; }   
    }

    public class DOGobj_inf
    {
        public string DepartamentalAffiliation { get; set; }

        public string Location { get; set; }

        public string AdmArea { get; set; }

        public string Lighting { get; set; }
        public string Fencing { get; set; }
    }

    public class UseCaseDOGobj
    {
        static string remoteUri = "https://apidata.mos.ru/v1/datasets/2663/rows?api_key=7a9b59cfbf252bb7e17e5260a49a9667";

        string path = @".\update_database\dogobj-";
        
        List<DOGobj_Cell> dogobj_cells;

        public List<dogobj> dogobjs = new List<dogobj>();

        public UseCaseDOGobj()
        {
            
            WebRequest request = WebRequest.Create(remoteUri);
            WebResponse response = request.GetResponse();
           
            StreamReader stream = new StreamReader(response.GetResponseStream());
            string line = stream.ReadToEnd();
            
            JArray jsonArray = JArray.Parse(line);
            
            dogobj_cells = JsonConvert.DeserializeObject<List<DOGobj_Cell>>(jsonArray.ToString());
         
            DateTime Date_update = DateTime.Now;
            string date_update = Date_update.ToShortDateString();

            path = path + date_update + @".json";
            
            using (FileStream fs2 = new FileStream(path, FileMode.OpenOrCreate))
            {
                
                var options = new JsonSerializerOptions
                {
                    Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                    WriteIndented = true
                };
                
                string text = "[";
                byte[] input = Encoding.Default.GetBytes(text);
               
                fs2.Write(input, 0, input.Length);
                text = ",";

                for (int i = 0; i < dogobj_cells.Count; i++)
                {
                    dogobjs.Add(new dogobj()
                    {
                        DepartamentalAffiliation = dogobj_cells[i].Cells.DepartamentalAffiliation,
                        Id = dogobj_cells[i].Number,
                        Location = dogobj_cells[i].Cells.Location,
                        AdmArea = dogobj_cells[i].Cells.AdmArea,
                        Lighting = dogobj_cells[i].Cells.Lighting,
                        Fencing = dogobj_cells[i].Cells.Fencing
                    });

                    System.Text.Json.JsonSerializer.SerializeAsync<dogobj>(fs2, dogobjs[i], options).GetAwaiter().GetResult();

                    if (i != dogobj_cells.Count - 1)
                    {
                        input = Encoding.Default.GetBytes(text);
                        fs2.Write(input, 0, input.Length);
                    }
                }

                text = "]";
                input = Encoding.Default.GetBytes(text);
                fs2.Write(input, 0, input.Length);
            }   
        }
    }
}

