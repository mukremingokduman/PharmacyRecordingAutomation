using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECZANE_4
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GIRIS());
        }
    }
}
/*
 * 
 * 
 *
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * CREATE TRIGGER ILACSTOK 
ON ILACEKLE 
FOR DELETE
AS 
BEGIN
UPDATE ILACEKLE SET STOK=STOK+1 WHERE ILACID=(SELECT ILACID FROM DELETED)
END


CREATE TRIGGER STOKK
ON  ILACEKLE
FOR INSERT
AS 
BEGIN
UPDATE ILACEKLE SET STOK=STOK-1 WHERE ILACID=(SELECT ILACID FROM INSERTED)
END






CREATE TRIGGER silinenkayitlartrg 
ON ILACEKLE 
FOR DELETE 
AS
INSERT INTO YAPILANISLEM
SELECT * FROM 
DELETED
 
 
 
 
 */