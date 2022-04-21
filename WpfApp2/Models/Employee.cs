using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.Models
{
    
    
        public class Employee : INotifyPropertyChanged
        {
            private string _name;

            public string Name
            {
                get { return _name; }
                set
                {
                    _name = value;
                    RaisePropertyChanged(Name.ToString());
                }
            }

            private int _id;

            public int Id
            {
                get { return _id; }
                set
                {
                    _id = value;
                    RaisePropertyChanged(Id.ToString());
                }
            }


            private string _cellNo;

            public string CellNo
            {
                get { return _cellNo; }
                set
                {
                    _cellNo = value;
                    RaisePropertyChanged(CellNo.ToString());
                }
            }

            private int _employeenum;
            public int Employeenum
            {
                get { return _employeenum; }
                set
                {
                    _employeenum = value;
                    RaisePropertyChanged(Employeenum.ToString());
                }
            }
            protected void RaisePropertyChanged(string propertyName)
            {
                var handler = PropertyChanged;

                if (handler != null)
                {
                    handler(this, new PropertyChangedEventArgs(propertyName));
                }
            }

            //PropertyChanged is interface member
            public event PropertyChangedEventHandler PropertyChanged;

        }
    }

