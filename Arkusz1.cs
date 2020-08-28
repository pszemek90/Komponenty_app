using System;
using System.Collections;
using System.Diagnostics;
using System.Windows.Forms;
using Tekla.Structures.Model;
using Tekla.Structures.Model.UI;
using Point = Tekla.Structures.Geometry3d.Point;

namespace Komponenty_app
{
    public partial class Arkusz1
    {
        private void Arkusz1_Startup(object sender, System.EventArgs e)
        {
            MyModel = new Model();
        }

        private Model MyModel;
        private void Arkusz1_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region Kod wygenerowany przez projektanta VSTO

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InternalStartup()
        {
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button5.Click += new System.EventHandler(this.button5_Click);
            this.button6.Click += new System.EventHandler(this.button6_Click);
            this.button7.Click += new System.EventHandler(this.button7_Click);
            this.button8.Click += new System.EventHandler(this.button8_Click);
            this.button9.Click += new System.EventHandler(this.button9_Click);
            this.button10.Click += new System.EventHandler(this.button10_Click);
            this.button11.Click += new System.EventHandler(this.button11_Click);
            this.button12.Click += new System.EventHandler(this.button12_Click);
            this.button13.Click += new System.EventHandler(this.button13_Click);
            this.button14.Click += new System.EventHandler(this.button14_Click);
            this.button15.Click += new System.EventHandler(this.button15_Click);
            this.button16.Click += new System.EventHandler(this.button16_Click);
            this.button17.Click += new System.EventHandler(this.button17_Click);
            this.button18.Click += new System.EventHandler(this.button18_Click);
            this.button19.Click += new System.EventHandler(this.button19_Click);
            this.button20.Click += new System.EventHandler(this.button20_Click);
            this.button21.Click += new System.EventHandler(this.button21_Click);
            this.button22.Click += new System.EventHandler(this.button22_Click);
            this.button23.Click += new System.EventHandler(this.button23_Click);
            this.button24.Click += new System.EventHandler(this.button24_Click);
            this.button25.Click += new System.EventHandler(this.button25_Click);
            this.button26.Click += new System.EventHandler(this.button26_Click);
            this.button27.Click += new System.EventHandler(this.button27_Click);
            this.button28.Click += new System.EventHandler(this.button28_Click);
            this.button29.Click += new System.EventHandler(this.button29_Click);
            this.button30.Click += new System.EventHandler(this.button30_Click);
            this.button31.Click += new System.EventHandler(this.button31_Click);
            this.button32.Click += new System.EventHandler(this.button32_Click);
            this.button33.Click += new System.EventHandler(this.button33_Click);
            this.button34.Click += new System.EventHandler(this.button34_Click);
            this.button35.Click += new System.EventHandler(this.button35_Click);
            this.button36.Click += new System.EventHandler(this.button36_Click);
            this.button37.Click += new System.EventHandler(this.button37_Click);
            this.button38.Click += new System.EventHandler(this.button38_Click);
            this.button39.Click += new System.EventHandler(this.button39_Click);
            this.button40.Click += new System.EventHandler(this.button40_Click);
            this.button41.Click += new System.EventHandler(this.button41_Click);
            this.button42.Click += new System.EventHandler(this.button42_Click);
            this.button43.Click += new System.EventHandler(this.button43_Click);
            this.button44.Click += new System.EventHandler(this.button44_Click);
            this.button45.Click += new System.EventHandler(this.button45_Click);
            this.button46.Click += new System.EventHandler(this.button46_Click);
            this.button47.Click += new System.EventHandler(this.button47_Click);
            this.button48.Click += new System.EventHandler(this.button48_Click);
            this.button49.Click += new System.EventHandler(this.button49_Click);
            this.button50.Click += new System.EventHandler(this.button50_Click);
            this.button51.Click += new System.EventHandler(this.button51_Click);
            this.Startup += new System.EventHandler(this.Arkusz1_Startup);
            this.Shutdown += new System.EventHandler(this.Arkusz1_Shutdown);

        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            Connection cp1 = new Connection();
            cp1.Name = "S_P_T_1000";
            cp1.Number = BaseComponent.CUSTOM_OBJECT_NUMBER;

            Picker piku = new Picker();
            ModelObject part = new Beam();
            ModelObject part2 = new Beam();
            try
            {
                part = piku.PickObject(Picker.PickObjectEnum.PICK_ONE_PART);
            }
            catch (Exception ex)
            {
            }
            try
            {
                part2 = piku.PickObject(Picker.PickObjectEnum.PICK_ONE_PART);
            }
            catch (Exception ex)
            {
            }
            cp1.SetPrimaryObject(part);
            cp1.SetSecondaryObject(part2);
            try
            {
                cp1.Insert();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się wstawić komponentu", "Error");
            }
            MyModel.CommitChanges();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Connection cp1 = new Connection();
            cp1.Name = "S_P_BS_1001";
            cp1.Number = BaseComponent.CUSTOM_OBJECT_NUMBER;

            Picker piku = new Picker();
            ModelObject part = new Beam();
            ModelObject part2 = new Beam();
            try
            {
                part = piku.PickObject(Picker.PickObjectEnum.PICK_ONE_PART);
            }
            catch (Exception ex)
            {
            }
            try
            {
                part2 = piku.PickObject(Picker.PickObjectEnum.PICK_ONE_PART);
            }
            catch (Exception ex)
            {
            }
            cp1.SetPrimaryObject(part);
            cp1.SetSecondaryObject(part2);
            try
            {
                cp1.Insert();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się wstawić komponentu", "Error");
            }
            MyModel.CommitChanges();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Connection cp1 = new Connection();
            cp1.Name = "S_P_BS_1002";
            cp1.Number = BaseComponent.CUSTOM_OBJECT_NUMBER;

            Picker piku = new Picker();
            ModelObject part = new Beam();
            ModelObject part2 = new Beam();
            try
            {
                part = piku.PickObject(Picker.PickObjectEnum.PICK_ONE_PART);
            }
            catch (Exception ex)
            {
            }
            try
            {
                part2 = piku.PickObject(Picker.PickObjectEnum.PICK_ONE_PART);
            }
            catch (Exception ex)
            {
            }
            cp1.SetPrimaryObject(part);
            cp1.SetSecondaryObject(part2);
            try
            {
                cp1.Insert();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się wstawić komponentu", "Error");
            }
            MyModel.CommitChanges();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Connection cp1 = new Connection();
            cp1.Name = "S_P_X_1003";
            cp1.Number = BaseComponent.CUSTOM_OBJECT_NUMBER;

            Picker piku = new Picker();
            ModelObject part = new Beam();
            ModelObject part2 = new Beam();
            try
            {
                part = piku.PickObject(Picker.PickObjectEnum.PICK_ONE_PART);
            }
            catch (Exception ex)
            {
            }
            try
            {
                part2 = piku.PickObject(Picker.PickObjectEnum.PICK_ONE_PART);
            }
            catch (Exception ex)
            {
            }
            cp1.SetPrimaryObject(part);
            cp1.SetSecondaryObject(part2);
            try
            {
                cp1.Insert();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się wstawić komponentu", "Error");
            }
            MyModel.CommitChanges();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Component cp1 = new Component();
            cp1.Name = "S_P_PG_1004";
            cp1.Number = BaseComponent.CUSTOM_OBJECT_NUMBER;

            Picker piku = new Picker();
            Point p1 = new Point();
            Point p2 = new Point();
            try
            {
                p1 = piku.PickPoint();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Brak wskazania, przyjęto punkt 0,0,0", "Error");
            }
            try
            {
                p2 = piku.PickPoint();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Brak wskazania, przyjęto punkt 0,0,0", "Error");
            }

            ComponentInput ci1 = new ComponentInput();
            ci1.AddOneInputPosition(p1);
            ci1.AddOneInputPosition(p2);
            cp1.SetComponentInput(ci1);
            if (p1 != p2)
            {
                cp1.Insert();
            }
            else
            {
                MessageBox.Show("Nie udało się wstawić komponentu, punkty są takie same", "Error");
            }
            MyModel.CommitChanges();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Component cp1 = new Component();
            cp1.Name = "S_P_PG_1005";
            cp1.Number = BaseComponent.CUSTOM_OBJECT_NUMBER;

            Picker piku = new Picker();
            Point p1 = new Point();
            Point p2 = new Point();
            try
            {
                p1 = piku.PickPoint();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Brak wskazania, przyjęto punkt 0,0,0", "Error");
            }
            try
            {
                p2 = piku.PickPoint();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Brak wskazania, przyjęto punkt 0,0,0", "Error");
            }
            ComponentInput ci1 = new ComponentInput();
            ci1.AddOneInputPosition(p1);
            ci1.AddOneInputPosition(p2);
            cp1.SetComponentInput(ci1);
            if (p1 != p2)
            {
                cp1.Insert();
            }
            else
            {
                MessageBox.Show("Nie udało się wstawić komponentu, punkty są takie same", "Error");
            }
            MyModel.CommitChanges();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Component cp1 = new Component();
            cp1.Name = "S_P_PG_1006";
            cp1.Number = BaseComponent.CUSTOM_OBJECT_NUMBER;

            Picker piku = new Picker();
            Point p1 = new Point();
            Point p2 = new Point();
            try
            {
                p1 = piku.PickPoint();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Brak wskazania, przyjęto punkt 0,0,0", "Error");
            }
            try
            {
                p2 = piku.PickPoint();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Brak wskazania, przyjęto punkt 0,0,0", "Error");
            }
            ComponentInput ci1 = new ComponentInput();
            ci1.AddOneInputPosition(p1);
            ci1.AddOneInputPosition(p2);
            cp1.SetComponentInput(ci1);
            if (p1 != p2)
            {
                cp1.Insert();
            }
            else
            {
                MessageBox.Show("Nie udało się wstawić komponentu, punkty są takie same", "Error");
            }
            MyModel.CommitChanges();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Component cp1 = new Component();
            cp1.Name = "S_P_PG_1007";
            cp1.Number = BaseComponent.CUSTOM_OBJECT_NUMBER;

            Picker piku = new Picker();
            Point p1 = new Point();
            Point p2 = new Point();
            try
            {
                p1 = piku.PickPoint();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Brak wskazania, przyjęto punkt 0,0,0", "Error");
            }
            try
            {
                p2 = piku.PickPoint();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Brak wskazania, przyjęto punkt 0,0,0", "Error");
            }
            ComponentInput ci1 = new ComponentInput();
            ci1.AddOneInputPosition(p1);
            ci1.AddOneInputPosition(p2);
            cp1.SetComponentInput(ci1);
            if (p1 != p2)
            {
                cp1.Insert();
            }
            else
            {
                MessageBox.Show("Nie udało się wstawić komponentu, punkty są takie same", "Error");
            }
            MyModel.CommitChanges();
        }

        private void button9_Click(object sender, EventArgs e)
        {

            Process ExternalProcess = new Process();
            ExternalProcess.StartInfo.FileName = @"P:\TeklaStructuresModels\XS_FIRM\Komponenty\S_P_ST_1008.exe";
            ExternalProcess.Start();
            ExternalProcess.WaitForExit();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Process ExternalProcess = new Process();
            ExternalProcess.StartInfo.FileName = @"P:\TeklaStructuresModels\XS_FIRM\Komponenty\S_P_ST_1009.exe";
            ExternalProcess.Start();
            ExternalProcess.WaitForExit();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Connection cp1 = new Connection();
            cp1.Name = "S_P_RR_1010";
            cp1.Number = BaseComponent.CUSTOM_OBJECT_NUMBER;

            Picker piku = new Picker();
            ModelObject part = new Beam();
            ModelObject part2 = new Beam();
            try
            {
                part = piku.PickObject(Picker.PickObjectEnum.PICK_ONE_PART);
            }
            catch (Exception ex)
            {
            }
            try
            {
                part2 = piku.PickObject(Picker.PickObjectEnum.PICK_ONE_PART);
            }
            catch (Exception ex)
            {
            }
            cp1.SetPrimaryObject(part);
            cp1.SetSecondaryObject(part2);
            try
            {
                cp1.Insert();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się wstawić komponentu", "Error");
            }
            MyModel.CommitChanges();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Connection cp1 = new Connection();
            cp1.Name = "S_P_SR_1011";
            cp1.Number = BaseComponent.CUSTOM_OBJECT_NUMBER;

            Picker piku = new Picker();
            ModelObject part = new Beam();
            ModelObject part2 = new Beam();
            try
            {
                part = piku.PickObject(Picker.PickObjectEnum.PICK_ONE_PART);
            }
            catch (Exception ex)
            {
            }
            try
            {
                part2 = piku.PickObject(Picker.PickObjectEnum.PICK_ONE_PART);
            }
            catch (Exception ex)
            {
            }
            cp1.SetPrimaryObject(part);
            cp1.SetSecondaryObject(part2);
            try
            {
                cp1.Insert();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się wstawić komponentu", "Error");
            }
            MyModel.CommitChanges();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Component cp1 = new Component();
            cp1.Name = "S_E_PZ_1012";
            cp1.Number = BaseComponent.CUSTOM_OBJECT_NUMBER;

            Picker piku = new Picker();
            Point p1 = new Point();
            Point p2 = new Point();
            try
            {
                p1 = piku.PickPoint();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Brak wskazania, przyjęto punkt 0,0,0", "Error");
            }
            try
            {
                p2 = piku.PickPoint();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Brak wskazania, przyjęto punkt 0,0,0", "Error");
            }
            ComponentInput ci1 = new ComponentInput();
            ci1.AddOneInputPosition(p1);
            ci1.AddOneInputPosition(p2);
            cp1.SetComponentInput(ci1);
            if (p1 != p2)
            {
                cp1.Insert();
            }
            else
            {
                MessageBox.Show("Nie udało się wstawić komponentu, punkty są takie same", "Error");
            }
            MyModel.CommitChanges();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Component cp1 = new Component();
            cp1.Name = "S_E_ST_1013";
            cp1.Number = BaseComponent.CUSTOM_OBJECT_NUMBER;

            Picker piku = new Picker();
            Point p1 = new Point();
            Point p2 = new Point();
            try
            {
                p1 = piku.PickPoint();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Brak wskazania, przyjęto punkt 0,0,0", "Error");
            }
            try
            {
                p2 = piku.PickPoint();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Brak wskazania, przyjęto punkt 0,0,0", "Error");
            }
            ComponentInput ci1 = new ComponentInput();
            ci1.AddOneInputPosition(p1);
            ci1.AddOneInputPosition(p2);
            cp1.SetComponentInput(ci1);
            if (p1 != p2)
            {
                cp1.Insert();
            }
            else
            {
                MessageBox.Show("Nie udało się wstawić komponentu, punkty są takie same", "Error");
            }
            MyModel.CommitChanges();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Connection cp1 = new Connection();
            cp1.Name = "S_P_BP_1014";
            cp1.Number = BaseComponent.CUSTOM_OBJECT_NUMBER;

            Picker piku = new Picker();
            ModelObject part = new Beam();
            ModelObject part2 = new Beam();
            try
            {
                part = piku.PickObject(Picker.PickObjectEnum.PICK_ONE_PART);
            }
            catch (Exception ex)
            {
            }
            try
            {
                part2 = piku.PickObject(Picker.PickObjectEnum.PICK_ONE_PART);
            }
            catch (Exception ex)
            {
            }
            cp1.SetPrimaryObject(part);
            cp1.SetSecondaryObject(part2);
            try
            {
                cp1.Insert();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się wstawić komponentu", "Error");
            }
            MyModel.CommitChanges();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Connection cp1 = new Connection();
            cp1.Name = "S_P_ST_1015";
            cp1.Number = BaseComponent.CUSTOM_OBJECT_NUMBER;

            Picker piku = new Picker();
            ModelObject part = new Beam();
            ModelObject part2 = new Beam();
            try
            {
                part = piku.PickObject(Picker.PickObjectEnum.PICK_ONE_PART);
            }
            catch (Exception ex)
            {
            }
            try
            {
                part2 = piku.PickObject(Picker.PickObjectEnum.PICK_ONE_PART);
            }
            catch (Exception ex)
            {
            }
            cp1.SetPrimaryObject(part);
            cp1.SetSecondaryObject(part2);
            try
            {
                cp1.Insert();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się wstawić komponentu", "Error");
            }
            MyModel.CommitChanges();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Detail cp1 = new Detail();
            cp1.Name = "S_E_SP_1016";
            cp1.Number = BaseComponent.CUSTOM_OBJECT_NUMBER;

            Picker piku = new Picker();
            ModelObject part = new Beam();
            Point p2 = new Point();
            try
            {
                part = piku.PickObject(Picker.PickObjectEnum.PICK_ONE_PART);
            }
            catch (Exception ex)
            {
            }
            try
            {
                p2 = piku.PickPoint();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Brak wskazania, przyjęto punkt 0,0,0", "Error");
            }
            ComponentInput ci1 = new ComponentInput();
            cp1.SetPrimaryObject(part);
            cp1.SetReferencePoint(p2);
            try
            {
                cp1.Insert();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się wstawić komponentu", "Error");
            }
            MyModel.CommitChanges();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Seam seam = new Seam();
            seam.Name = "Z_K_SZ_2000";
            seam.Number = BaseComponent.CUSTOM_OBJECT_NUMBER;

            Picker picker = new Picker();
            ModelObject mainPart = new Beam();
            ModelObject secondaryPart = new Beam();
            Point startPoint = new Point();
            Point endPoint = new Point();

            mainPart = picker.PickObject(Picker.PickObjectEnum.PICK_ONE_PART);
            secondaryPart = picker.PickObject(Picker.PickObjectEnum.PICK_ONE_PART);

            startPoint = picker.PickPoint();
            endPoint = picker.PickPoint();

            seam.SetPrimaryObject(mainPart);
            seam.SetSecondaryObject(secondaryPart);
            seam.SetInputPositions(startPoint, endPoint);

            try
            {
                seam.Insert();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Nie udało się wstawić komponentu", "Error");
            }
            MyModel.CommitChanges();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            connection.Name = "Z_P_PDl_2001";
            connection.Number = BaseComponent.CUSTOM_OBJECT_NUMBER;

            Picker picker = new Picker();
            ModelObject mainPart = picker.PickObject(Picker.PickObjectEnum.PICK_ONE_PART);
            ModelObject secondaryPart = picker.PickObject(Picker.PickObjectEnum.PICK_ONE_PART);

            connection.SetPrimaryObject(mainPart);
            connection.SetSecondaryObject(secondaryPart);

            try
            {
                connection.Insert();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Nie udało się wstawić komponentu", "Error");
            }
            MyModel.CommitChanges();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            connection.Name = "Z_P_PDp_2002 ";
            connection.Number = BaseComponent.CUSTOM_OBJECT_NUMBER;

            Picker picker = new Picker();
            ModelObject mainPart = picker.PickObject(Picker.PickObjectEnum.PICK_ONE_PART);
            ModelObject secondaryPart = picker.PickObject(Picker.PickObjectEnum.PICK_ONE_PART);

            connection.SetPrimaryObject(mainPart);
            connection.SetSecondaryObject(secondaryPart);

            try
            {
                connection.Insert();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się wstawić komponentu", "Error");
            }
            MyModel.CommitChanges();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Seam seam = new Seam();
            seam.Name = "Z_P_SZ_2003";
            seam.Number = BaseComponent.CUSTOM_OBJECT_NUMBER;

            Picker picker = new Picker();
            ModelObject mainPart = new Beam();
            ModelObject secondaryPart = new Beam();
            Point startPoint = new Point();
            Point endPoint = new Point();

            mainPart = picker.PickObject(Picker.PickObjectEnum.PICK_ONE_PART);
            secondaryPart = picker.PickObject(Picker.PickObjectEnum.PICK_ONE_PART);

            startPoint = picker.PickPoint();
            endPoint = picker.PickPoint();

            seam.SetPrimaryObject(mainPart);
            seam.SetSecondaryObject(secondaryPart);
            seam.SetInputPositions(startPoint, endPoint);

            try
            {
                seam.Insert();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się wstawić komponentu", "Error");
            }
            MyModel.CommitChanges();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Detail detail = new Detail();
            detail.Name = "Z_D_MSO_2004";
            detail.Number = BaseComponent.CUSTOM_OBJECT_NUMBER;

            Picker picker = new Picker();
            detail.SetPrimaryObject(picker.PickObject(Picker.PickObjectEnum.PICK_ONE_PART));

            try
            {
                detail.Insert();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Nie udało się wstawić komponentu", "Error");
            }
            MyModel.CommitChanges();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Detail detail = new Detail();
            detail.Name = "Z_E_SL_2007";
            detail.Number = BaseComponent.CUSTOM_OBJECT_NUMBER;

            Picker picker = new Picker();
            detail.SetPrimaryObject(picker.PickObject(Picker.PickObjectEnum.PICK_ONE_PART));

            try
            {
                detail.Insert();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się wstawić komponentu", "Error");
            }
            MyModel.CommitChanges();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Detail detail = new Detail();
            detail.Name = "Z_E_SL_2008";
            detail.Number = BaseComponent.CUSTOM_OBJECT_NUMBER;

            Picker picker = new Picker();
            detail.SetPrimaryObject(picker.PickObject(Picker.PickObjectEnum.PICK_ONE_PART));

            try
            {
                detail.Insert();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się wstawić komponentu", "Error");
            }
            MyModel.CommitChanges();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Detail detail = new Detail();
            detail.Name = "Z_E_SL_2009";
            detail.Number = BaseComponent.CUSTOM_OBJECT_NUMBER;

            Picker picker = new Picker();
            detail.SetPrimaryObject(picker.PickObject(Picker.PickObjectEnum.PICK_ONE_PART));

            try
            {
                detail.Insert();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się wstawić komponentu", "Error");
            }
            MyModel.CommitChanges();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Detail detail = new Detail();
            detail.Name = "Z_E_SL_2010";
            detail.Number = BaseComponent.CUSTOM_OBJECT_NUMBER;

            Picker picker = new Picker();
            detail.SetPrimaryObject(picker.PickObject(Picker.PickObjectEnum.PICK_ONE_PART));

            try
            {
                detail.Insert();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się wstawić komponentu", "Error");
            }
            MyModel.CommitChanges();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Detail detail = new Detail();
            detail.Name = "Z_E_SL_2011";
            detail.Number = BaseComponent.CUSTOM_OBJECT_NUMBER;

            Picker picker = new Picker();
            detail.SetPrimaryObject(picker.PickObject(Picker.PickObjectEnum.PICK_ONE_PART));

            try
            {
                detail.Insert();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się wstawić komponentu", "Error");
            }
            MyModel.CommitChanges();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            CustomPart customPart = new CustomPart();
            customPart.Name = "Z_E_SL_2012";
            customPart.Number = BaseComponent.CUSTOM_OBJECT_NUMBER;

            Picker picker = new Picker();
            customPart.SetInputPositions(picker.PickPoint(), picker.PickPoint());

            try
            {
                customPart.Insert();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się wstawić komponentu", "Error");
            }
            MyModel.CommitChanges();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Detail detail = new Detail();
            detail.Name = "Z_E_SL_2013";
            detail.Number = BaseComponent.CUSTOM_OBJECT_NUMBER;

            Picker picker = new Picker();
            detail.SetPrimaryObject(picker.PickObject(Picker.PickObjectEnum.PICK_ONE_PART));
            detail.SetReferencePoint(picker.PickPoint());

            try
            {
                detail.Insert();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się wstawić komponentu", "Error");
            }
            MyModel.CommitChanges();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            CustomPart customPart = new CustomPart();
            customPart.Name = "Z_E_BSP_2014";
            customPart.Number = BaseComponent.CUSTOM_OBJECT_NUMBER;

            Picker picker = new Picker();
            Point startPoint = picker.PickPoint();
            customPart.SetInputPositions(startPoint, startPoint + new Point(0,0,1000));

            try
            {
                customPart.Insert();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się wstawić komponentu", "Error");
            }
            MyModel.CommitChanges();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            CustomPart customPart = new CustomPart();
            customPart.Name = "Z_E_B_2015";
            customPart.Number = BaseComponent.CUSTOM_OBJECT_NUMBER;

            Picker picker = new Picker();
            Point startPoint = picker.PickPoint();
            customPart.SetInputPositions(startPoint, startPoint + new Point(0, 0, 1000));

            try
            {
                customPart.Insert();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się wstawić komponentu", "Error");
            }
            MyModel.CommitChanges();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            CustomPart customPart = new CustomPart();
            customPart.Name = "Z_E_DZ_2016";
            customPart.Number = BaseComponent.CUSTOM_OBJECT_NUMBER;

            Picker picker = new Picker();
            Point startPoint = picker.PickPoint();
            customPart.SetInputPositions(startPoint, startPoint + new Point(0, 0, 1000));

            try
            {
                customPart.Insert();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się wstawić komponentu", "Error");
            }
            MyModel.CommitChanges();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            CustomPart customPart = new CustomPart();
            customPart.Name = "Z_E_DZ_2017";
            customPart.Number = BaseComponent.CUSTOM_OBJECT_NUMBER;

            Picker picker = new Picker();
            Point startPoint = picker.PickPoint();
            customPart.SetInputPositions(startPoint, startPoint + new Point(0, 0, 1000));

            try
            {
                customPart.Insert();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się wstawić komponentu", "Error");
            }
            MyModel.CommitChanges();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            CustomPart customPart = new CustomPart();
            customPart.Name = "Z_E_MS_2018";
            customPart.Number = BaseComponent.CUSTOM_OBJECT_NUMBER;

            Picker picker = new Picker();
            Point startPoint = picker.PickPoint();
            customPart.SetInputPositions(startPoint, startPoint + new Point(0, 0, 1000));

            try
            {
                customPart.Insert();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się wstawić komponentu", "Error");
            }
            MyModel.CommitChanges();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            CustomPart customPart = new CustomPart();
            customPart.Name = "Z_E_MS_2005";
            customPart.Number = BaseComponent.CUSTOM_OBJECT_NUMBER;

            Picker picker = new Picker();
            Point startPoint = picker.PickPoint();
            customPart.SetInputPositions(startPoint, startPoint + new Point(0, 0, 1000));

            try
            {
                customPart.Insert();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się wstawić komponentu", "Error");
            }
            MyModel.CommitChanges();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            CustomPart customPart = new CustomPart();
            customPart.Name = "Z_E_PD_2022";
            customPart.Number = BaseComponent.CUSTOM_OBJECT_NUMBER;

            Picker picker = new Picker();
            customPart.SetInputPositions(picker.PickPoint(), picker.PickPoint());

            try
            {
                customPart.Insert();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się wstawić komponentu", "Error");
            }
            MyModel.CommitChanges();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            CustomPart customPart = new CustomPart();
            customPart.Name = "Z_E_SL_2023";
            customPart.Number = BaseComponent.CUSTOM_OBJECT_NUMBER;

            Picker picker = new Picker();
            customPart.SetInputPositions(picker.PickPoint(), picker.PickPoint());

            try
            {
                customPart.Insert();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się wstawić komponentu", "Error");
            }
            MyModel.CommitChanges();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            connection.Name = "Z_P_PDl_2024";
            connection.Number = BaseComponent.CUSTOM_OBJECT_NUMBER;

            Picker picker = new Picker();
            ModelObject mainPart = picker.PickObject(Picker.PickObjectEnum.PICK_ONE_PART);
            ModelObject secondaryPart = picker.PickObject(Picker.PickObjectEnum.PICK_ONE_PART);

            connection.SetPrimaryObject(mainPart);
            connection.SetSecondaryObject(secondaryPart);

            try
            {
                connection.Insert();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się wstawić komponentu", "Error");
            }
            MyModel.CommitChanges();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            connection.Name = "Z_P_PDp_2025";
            connection.Number = BaseComponent.CUSTOM_OBJECT_NUMBER;

            Picker picker = new Picker();
            ModelObject mainPart = picker.PickObject(Picker.PickObjectEnum.PICK_ONE_PART);
            ModelObject secondaryPart = picker.PickObject(Picker.PickObjectEnum.PICK_ONE_PART);

            connection.SetPrimaryObject(mainPart);
            connection.SetSecondaryObject(secondaryPart);

            try
            {
                connection.Insert();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się wstawić komponentu", "Error");
            }
            MyModel.CommitChanges();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            Detail detail = new Detail();
            detail.Name = "Z_D_SL_2026";
            detail.Number = BaseComponent.CUSTOM_OBJECT_NUMBER;

            Picker picker = new Picker();
            detail.SetPrimaryObject(picker.PickObject(Picker.PickObjectEnum.PICK_ONE_PART));
            detail.SetReferencePoint(picker.PickPoint());

            try
            {
                detail.Insert();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się wstawić komponentu", "Error");
            }
            MyModel.CommitChanges();
        }

        private void button41_Click(object sender, EventArgs e)
        {
            Detail detail = new Detail();
            detail.Name = "Z_D_SL_2027";
            detail.Number = BaseComponent.CUSTOM_OBJECT_NUMBER;

            Picker picker = new Picker();
            detail.SetPrimaryObject(picker.PickObject(Picker.PickObjectEnum.PICK_ONE_PART));

            try
            {
                detail.Insert();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się wstawić komponentu", "Error");
            }
            MyModel.CommitChanges();
        }

        private void button42_Click(object sender, EventArgs e)
        {
            Detail detail = new Detail();
            detail.Name = "Z_D_DZ_2028";
            detail.Number = BaseComponent.CUSTOM_OBJECT_NUMBER;

            Picker picker = new Picker();
            detail.SetPrimaryObject(picker.PickObject(Picker.PickObjectEnum.PICK_ONE_PART));
            detail.SetReferencePoint(picker.PickPoint());

            try
            {
                detail.Insert();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się wstawić komponentu", "Error");
            }
            MyModel.CommitChanges();
        }

        private void button43_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            connection.Name = "Z_P_DZ_2029";
            connection.Number = BaseComponent.CUSTOM_OBJECT_NUMBER;

            Picker picker = new Picker();
            ModelObject mainPart = picker.PickObject(Picker.PickObjectEnum.PICK_ONE_PART);
            ModelObject secondaryPart = picker.PickObject(Picker.PickObjectEnum.PICK_ONE_PART);

            connection.SetPrimaryObject(mainPart);
            connection.SetSecondaryObject(secondaryPart);

            try
            {
                connection.Insert();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się wstawić komponentu", "Error");
            }
            MyModel.CommitChanges();
        }

        private void button44_Click(object sender, EventArgs e)
        {
            Seam seam = new Seam();
            seam.Name = "Z_K_PD_2030";
            seam.Number = BaseComponent.CUSTOM_OBJECT_NUMBER;

            Picker picker = new Picker();

            ModelObject mainPart = picker.PickObject(Picker.PickObjectEnum.PICK_ONE_PART);
            ModelObjectEnumerator partsEnumerator = picker.PickObjects(Picker.PickObjectsEnum.PICK_N_OBJECTS);
            ArrayList secondaryParts = new ArrayList();

            foreach (ModelObject modelObject in partsEnumerator){
                secondaryParts.Add(modelObject);
            }

            Point startPoint = picker.PickPoint();
            Point endPoint = picker.PickPoint();

            seam.SetPrimaryObject(mainPart);
            seam.SetSecondaryObjects(secondaryParts);
            seam.SetInputPositions(startPoint, endPoint);

            try
            {
                seam.Insert();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się wstawić komponentu", "Error");
            }
            MyModel.CommitChanges();
        }

        private void button45_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            connection.Name = "Z_P_DZ_2031";
            connection.Number = BaseComponent.CUSTOM_OBJECT_NUMBER;

            Picker picker = new Picker();
            ModelObject mainPart = picker.PickObject(Picker.PickObjectEnum.PICK_ONE_PART);
            ModelObject secondaryPart = picker.PickObject(Picker.PickObjectEnum.PICK_ONE_PART);

            connection.SetPrimaryObject(mainPart);
            connection.SetSecondaryObject(secondaryPart);

            try
            {
                connection.Insert();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się wstawić komponentu", "Error");
            }
            MyModel.CommitChanges();
        }

        private void button46_Click(object sender, EventArgs e)
        {
            Seam seam = new Seam();
            seam.Name = "Z_K_SZ_2032";
            seam.Number = BaseComponent.CUSTOM_OBJECT_NUMBER;

            Picker picker = new Picker();

            ModelObject mainPart = picker.PickObject(Picker.PickObjectEnum.PICK_ONE_PART);
            ModelObjectEnumerator partsEnumerator = picker.PickObjects(Picker.PickObjectsEnum.PICK_N_OBJECTS);
            ArrayList secondaryParts = new ArrayList();

            foreach (ModelObject modelObject in partsEnumerator)
            {
                secondaryParts.Add(modelObject);
            }

            Point startPoint = picker.PickPoint();
            Point endPoint = picker.PickPoint();

            seam.SetPrimaryObject(mainPart);
            seam.SetSecondaryObjects(secondaryParts);
            seam.SetInputPositions(startPoint, endPoint);

            try
            {
                seam.Insert();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się wstawić komponentu", "Error");
            }
            MyModel.CommitChanges();
        }

        private void button47_Click(object sender, EventArgs e)
        {
            Detail detail = new Detail();
            detail.Name = "Z_D_MS_2033";
            detail.Number = BaseComponent.CUSTOM_OBJECT_NUMBER;

            Picker picker = new Picker();
            detail.SetPrimaryObject(picker.PickObject(Picker.PickObjectEnum.PICK_ONE_PART));
            detail.SetReferencePoint(picker.PickPoint());

            try
            {
                detail.Insert();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się wstawić komponentu", "Error");
            }
            MyModel.CommitChanges();
        }

        private void button48_Click(object sender, EventArgs e)
        {
            Detail detail = new Detail();
            detail.Name = "Z_D_DZ_2034";
            detail.Number = BaseComponent.CUSTOM_OBJECT_NUMBER;

            Picker picker = new Picker();
            detail.SetPrimaryObject(picker.PickObject(Picker.PickObjectEnum.PICK_ONE_PART));
            detail.SetReferencePoint(picker.PickPoint());

            try
            {
                detail.Insert();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się wstawić komponentu", "Error");
            }
            MyModel.CommitChanges();
        }

        private void button49_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            connection.Name = "Z_P_DZ_2035";
            connection.Number = BaseComponent.CUSTOM_OBJECT_NUMBER;

            Picker picker = new Picker();
            ModelObject mainPart = picker.PickObject(Picker.PickObjectEnum.PICK_ONE_PART);
            ModelObject secondaryPart = picker.PickObject(Picker.PickObjectEnum.PICK_ONE_PART);

            connection.SetPrimaryObject(mainPart);
            connection.SetSecondaryObject(secondaryPart);

            try
            {
                connection.Insert();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się wstawić komponentu", "Error");
            }
            MyModel.CommitChanges();
        }

        private void button50_Click(object sender, EventArgs e)
        {
            Seam seam = new Seam();
            seam.Name = "Z_K_SZ_2032";
            seam.Number = BaseComponent.CUSTOM_OBJECT_NUMBER;

            Picker picker = new Picker();

            ModelObject mainPart = picker.PickObject(Picker.PickObjectEnum.PICK_ONE_PART);
            ModelObjectEnumerator partsEnumerator = picker.PickObjects(Picker.PickObjectsEnum.PICK_N_OBJECTS);
            ArrayList secondaryParts = new ArrayList();

            foreach (ModelObject modelObject in partsEnumerator)
            {
                secondaryParts.Add(modelObject);
            }

            Point startPoint = picker.PickPoint();
            Point endPoint = picker.PickPoint();

            seam.SetPrimaryObject(mainPart);
            seam.SetSecondaryObjects(secondaryParts);
            seam.SetInputPositions(startPoint, endPoint);

            try
            {
                seam.Insert();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się wstawić komponentu", "Error");
            }
            MyModel.CommitChanges();
        }

        private void button51_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            connection.Name = "Z_P_DZ_2037";
            connection.Number = BaseComponent.CUSTOM_OBJECT_NUMBER;

            Picker picker = new Picker();
            ModelObject mainPart = picker.PickObject(Picker.PickObjectEnum.PICK_ONE_PART);
            ModelObject secondaryPart = picker.PickObject(Picker.PickObjectEnum.PICK_ONE_PART);

            connection.SetPrimaryObject(mainPart);
            connection.SetSecondaryObject(secondaryPart);

            try
            {
                connection.Insert();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się wstawić komponentu", "Error");
            }
            MyModel.CommitChanges();
        }
    }
}
