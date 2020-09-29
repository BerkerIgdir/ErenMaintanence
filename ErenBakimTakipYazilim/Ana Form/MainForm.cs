using Core.Extensions;
using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Form;
using Entities.Tables;
using Business.Workers;
using Entities.Enums;
using ErenBakimTakipYazilim.Usta_Veri_Giris;
using System.Security.Principal;
using ErenBakimTakipYazilim.Veri_Okuma;
using System.Threading.Tasks;
namespace ErenBakimTakipYazilim
{
    public partial class MainForm : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        private readonly KumasAndIplikWorker worker = new KumasAndIplikWorker();



        public MainForm()
        {
            InitializeComponent();
            if (!ConnectionStringGetter.Check())
            {
                ConnectionForm ConnectionForm = new ConnectionForm();
                ConnectionForm.ShowDialog();
            }

            DateTime start = DateTime.Now;
            Arranger(WindowsIdentity.GetCurrent());
            DateTime finish = DateTime.Now;
            MessageBox.Show((finish - start).ToString());
            MessageBox.Show(worker.ManipulatorEmployeeService.Get(c => c.Name == "Berker").RelatedFactory.FactoryName);

        }

        private void Arranger (WindowsIdentity Identity)
        {
            var Person = worker.EmployeeService.Get(c => c.ComputerIdentity == Identity.Name);

            if (Person == null)
            {
                MessageBox.Show("Bilgisayar, programı kullanmaya yetkili değil.");
               
                return;
            }

            switch (Person.Authority)
            {
                case AuthorityTypes.Viewer:

                    foreach (var Factory in worker.FactoryService.GetList(null))
                    {

                        var ViewerButton = new DevExpress.XtraBars.Navigation.AccordionControlElement { Text = Factory.FactoryName };
                        foreach (var Machine in worker.MachineService.GetList(c => c.FactoryId == Factory.ID))
                        {
                            var Item = new DevExpress.XtraBars.Navigation.AccordionControlElement { Text = Machine.Name };
                            ViewerButton.Elements.Add(Item);
                            Item.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
                            Item.Click += (object sender, EventArgs e) =>
                            {
                                var control = new DataMonitoringControl(Factory.FactoryName,worker)
                                {
                                    Dock = DockStyle.Fill
                                };

                                fluentDesignFormContainer1.Controls.Add(control);
                                control.BringToFront();
                            };
                        }
                        DataMonitoring.Elements.Add(ViewerButton);
                    }

                    break;
                    
                case AuthorityTypes.Manipulator:

                    var Manipulator = (ManipulatorEmployee)Person;
                    var MyFactory = worker.FactoryService.Get(c => c.ID == Manipulator.FactoryId);
                    var Button = new DevExpress.XtraBars.Navigation.AccordionControlElement { Text = MyFactory.FactoryName };
                    Parallel.ForEach(worker.MachineService.GetList(c => c.FactoryId == Manipulator.RelatedFactory.ID), Machine =>
                    {
                        var Item = new DevExpress.XtraBars.Navigation.AccordionControlElement { Text = Machine.Name };
                        Button.Elements.Add(Item);
                        Item.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
                        Item.Click += (object sender, EventArgs e) =>
                        {
                            var control = new DataMonitoringControl(MyFactory.FactoryName,worker)
                            {
                                Dock = DockStyle.Fill
                            };

                            fluentDesignFormContainer1.Controls.Add(control);
                            control.BringToFront();
                        };
                    }
                    );

                    //foreach (var Machine in worker.MachineService.GetList(c => c.FactoryId == Manipulator.RelatedFactory.ID))
                    //{
                    //    var Item = new DevExpress.XtraBars.Navigation.AccordionControlElement { Text = Machine.Name };
                    //    Button.Elements.Add(Item);
                    //    Item.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
                    //    Item.Click += (object sender, EventArgs e) =>
                    //    {
                    //        var control = new DataMonitoringControl()
                    //        {
                    //            Dock = DockStyle.Fill
                    //        };

                    //        fluentDesignFormContainer1.Controls.Add(control);
                    //        control.BringToFront();
                    //    };
                    //}
                    DataMonitoring.Elements.Add(Button);
                    break;
                    
                default:
                    MessageBox.Show("Yanlışlık var !");
                    break;
            }




        }

        private void InitializeControls(object sender , EventArgs e)
        {

            MessageBox.Show("Tıkladın Butona");
        }

        private void ControlDelete(object sender, EventArgs e)
        {
           
        }

        private void ControlSave(object sender, EventArgs e)
        {

        }

        private void CostControlElement_Click(object sender, EventArgs e)
        {
            var CostControlTable = new CostControl(worker)
            {
                Dock = DockStyle.Fill
            };

            fluentDesignFormContainer1.Controls.Add(CostControlTable);

            CostControlTable.BringToFront();
        }

        private void CrashControlElement_Click(object sender, EventArgs e)
        {
            var control = new VeriGirisControl(worker)
            {
                Dock = DockStyle.Fill
            };
            
            fluentDesignFormContainer1.Controls.Add(control);
            control.BringToFront();
            control.DeleteOnClick += new EventHandler(ControlDelete);
            control.SaveOnClick += new EventHandler(ControlSave);
        }

        private void DataMonitoring_Click(object sender, EventArgs e)
        {

        }
    }
}
