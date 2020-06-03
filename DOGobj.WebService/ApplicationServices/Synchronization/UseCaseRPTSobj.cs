using System;
using System.Collections.Generic;
using System.Net;
using DOGobj.DomainObjects;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

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
        public string Name { get; set; }

        public string Landmark { get; set; }

        public string SiteElements { get; set; }

        public string PlatformLighting { get; set; }
        public string FencingSite { get; set; }
    }


    public class UseCaseDOGobj
    {
        static string remoteUri = "https://apidata.mos.ru/v1/datasets/2663/rows?api_key=7a9b59cfbf252bb7e17e5260a49a9667";

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


            for (int i = 0; i < dogobj_cells.Count; i++)
            {
                dogobjs.Add(new dogobj()
                {
                    Name = dogobj_cells[i].Cells.Name,
                    Id = dogobj_cells[i].Number,
                    Landmark = dogobj_cells[i].Cells.Landmark,
                    SiteElements = dogobj_cells[i].Cells.SiteElements,
                    PlatformLighting = dogobj_cells[i].Cells.PlatformLighting,
                    FencingSite = dogobj_cells[i].Cells.FencingSite
                });
            }
        }

    }
}