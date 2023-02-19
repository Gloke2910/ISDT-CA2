using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using NPOI.SS.UserModel;
using NPOI.HSSF.UserModel;

//---------------------------------------------------------------------------------
// Author		: Gabriel Loke 
// Date  		: 2023-02-18
// Description	: Exports enemies that user attacked in order to Excel file in Output folder.
//---------------------------------------------------------------------------------
public class Tracking : MonoBehaviour {

    // public onClickRed Red;
    // public onClickBlue Blue;
    // public onClickGreen Green;

	private string excelName;

    //public GameObject CubeRed;
	// public GameObject CubeBlue;
    // public GameObject CubeGreen;

	public string Enemy1 = "GiantRedDragon";
    public string Enemy2 = "SmallRedDragon";
    public string Enemy3 = "BlueDragon";
    public string Enemy4 = "Rubble";
    public string Enemy5 = "Tree";
    public DateTime Datetime;

    public void OnClick() {
        HSSFWorkbook book;
            using (FileStream file = new FileStream(Application.dataPath + "/Output/" + excelName, FileMode.Open, FileAccess.Read))
            {
                book = new HSSFWorkbook(file);
                file.Close();
            }

            ISheet sheet = book.GetSheetAt(0);

            IRow hRow = sheet.GetRow(0);
            IRow row = sheet.CreateRow(sheet.LastRowNum);

            for (int i = 0; i < hRow.LastCellNum; i++)
            {
                if (i == 0) {
                    row.CreateCell(i).SetCellValue("User");
                }
                if (i == 1) {
                    row.CreateCell(i).SetCellValue(Datetime.ToString("HH:mm:ss:tt"));
                }
                if (i == 2) {
                    row.CreateCell(i).SetCellValue(DateTime.Now.ToString("HH:mm:ss:tt"));
                }
                if (i == 3 && Enemy1 == "GiantRedDragon") {
                    row.CreateCell(i).SetCellValue("Giant Red Dragon");
                }
                if (i == 4 && Enemy2 == "SmallRedDragon") {
                    row.CreateCell(i).SetCellValue("Small Red Dragon");
                }
                if (i == 5 && Enemy3 == "BlueDragon") {
                    row.CreateCell(i).SetCellValue("Blue Dragon");
                }
                if (i == 6 && Enemy4 == "Rubble") {
                    row.CreateCell(i).SetCellValue("Rubble");
                }
                if (i == 7 && Enemy5 == "Tree") {
                    row.CreateCell(i).SetCellValue("Tree");
                }
                if (i == 8) {
                    if (Enemy1 == "GiantRedDragon" && Enemy2 == "SmallRedDragon" && Enemy3 == "BlueDragon" && Enemy4 == "Rubble" && Enemy5 == "Tree") {
                        row.CreateCell(i).SetCellValue("Pass");
                    }
                    else {
                        row.CreateCell(i).SetCellValue("Fail");
                    }
                }
            }
            
            sheet.CreateRow(sheet.LastRowNum + 1).CreateCell(0).SetCellValue("-END-");

            using (FileStream file = new FileStream(Application.dataPath + "/Output/" + excelName, FileMode.Open, FileAccess.Write))
            {
                book.Write(file);
                file.Close();
            }
    }
    

	void Start() {
		RunTimeTest();
        DateTime dt = DateTime.Now;
        Datetime = dt;
	}

    public void writeOutput(GameObject go) {
        Debug.Log(go.name);
    }

	void RunTimeTest(){
		DateTime dt = DateTime.Now;
		excelName = dt.ToString("yyyy-MM-dd") + ".xls";

        string path = Application.dataPath + "/Output/";

        if (!Directory.Exists(path))
        {
            Debug.Log("Create Directory");
            Directory.CreateDirectory(path);
        }

        Debug.Log("streaming assets: " + Application.streamingAssetsPath);
            

        if (System.IO.File.Exists (path + excelName)) {
			Debug.Log ("File Exist: ["+path+"]");
		} else {
			Debug.Log ("File DOES NOT Exist");

			//*****
			IWorkbook book = new HSSFWorkbook();;
            //using (var file = new FileStream(path, FileMode.Open, FileAccess.ReadWrite)) {
            //	book = new XSSFWorkbook();
            //}
            ISheet sheet = book.CreateSheet("Batch"+ dt.ToString("yyyy-MM-dd"));
            sheet.CreateRow(0).CreateCell(0).SetCellValue("Name");

            //*
            sheet.GetRow(0).CreateCell(1).SetCellValue("StartTime");
            sheet.GetRow(0).CreateCell(2).SetCellValue("EndTime");
            sheet.GetRow(0).CreateCell(3).SetCellValue("Task 1");
            sheet.GetRow(0).CreateCell(4).SetCellValue("Task 2");
            sheet.GetRow(0).CreateCell(5).SetCellValue("Task 3");
            sheet.GetRow(0).CreateCell(6).SetCellValue("Task 4");
            sheet.GetRow(0).CreateCell(8).SetCellValue("Task 5");
            
            //******/

            sheet.CreateRow(sheet.LastRowNum+1).CreateCell(0).SetCellValue("-END-");
            Debug.Log("Last ROW: " + sheet.LastRowNum);

            //save
            FileStream xfile = File.Create(path+excelName);
            book.Write(xfile);
            xfile.Close();
            

        }
	}
}
