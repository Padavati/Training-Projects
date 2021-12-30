using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileHandlingApp
{
    class House
    {
        public void CreateHouse()
        {
            // step 1 File Creation
            FileStream filestreamObj = new FileStream("C:\\Test\\MyFile.txt",FileMode.Create,FileAccess.Write);
            //file write operation
            StreamWriter sw = new StreamWriter(filestreamObj);
            sw.WriteLine("welcome");
            sw.Close();
            filestreamObj.Close();
        }
        public void ReadHouseDetails()
        {

        }
        
    }
}
