//using DependencyInjection.Domain.Repository;
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DependencyInjection.Data.Repository
//{
//    class CSVRepository:IRepository
//    {
//        public void CreateDetails(Domain.Model.Details d)
//        {
//            string fileName = "people.txt";
//            var path = AppDomain.CurrentDomain.BaseDirectory + fileName;
//            using (StreamWriter file = new StreamWriter(path))
//            {
              
//                file.Write(d.id);
//                file.Write(d.FirstName);
//                file.Write(d.LastName);

//            }

//        }
//    }
//}
