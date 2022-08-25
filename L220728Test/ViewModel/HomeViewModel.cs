using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using L220728Test.Event;
using Stylet;
using L220728Test.View;
using MaxwellFramework.AnimationManager.Animation;
using MaxwellFramework.AnimationManager.Animation.Model;
using System.Threading;
using L220728Test.Model;
using System.Windows;

namespace L220728Test.ViewModel
{  
    public class HomeViewModel : Screen
    {
        public AnimationContainer Animation { get; set; } = new AnimationContainer();
        public DrivingModel drivingModel { get; set; } = new DrivingModel() { MoveScale = 1, RotateScale = 1};

        private List<HomeModel> _cartoonModels = new List<HomeModel>()
        {
          new HomeModel(){ AxisName="1",ActionName={ "down1", "up1", "right1", "left1"},MoveScale={ 1, 2 },RotateScale={ 1, 2 } },
          //new HomeModel(){ AxisName="2",ActionName={ "right1", "left2"},MoveScale=new List<int>(){ 1, 2 },RotateScale=new List<int>(){ 1, 2 } },
          new HomeModel(){ AxisName="3",ActionName={ "right3", "turn3", "return3", "left3"},MoveScale={ 1, 2 },RotateScale={ 1, 2 } }
        };
        public List<HomeModel> CartoonModels
        {
            get { return _cartoonModels; }
            set
            {
                _cartoonModels = value; OnPropertyChanged(nameof(CartoonModels));
            }
        }

        private HomeModel _selectItem;
        public HomeModel SelectItem
        {
            get { return _selectItem; }
            set
            {
                _selectItem = value; OnPropertyChanged(nameof(SelectItem));
            }
        }
        private double _rota = 1;
        public double Rota
        {
            get { return _rota; }
            set
            {
                _rota = value; OnPropertyChanged(nameof(Rota));
            }
        }
        private double _move = 1;
        public double Move
        {
            get { return _move; }
            set
            {
                _move = value; OnPropertyChanged(nameof(Move));
            }
        }
        public string _act;
        public string Act
        {
            get { return _act; }
            set
            {
                _act = value; OnPropertyChanged(nameof(Act));
            }
        }
        //public HomeModel CartoonModels { get; set; } = new HomeModel() { 
        //    AxisName = { "1", "3" },
        //    ActionName = { "down1", "up1", "right1", "left1", "right3", "turn3", "return3", "left3" }, 
        //    MoveScale = { 1, 2 },
        //    RotateScale = { 1, 2 }
        //};
        public HomeViewModel()
        {
  
        }
        protected override void OnViewLoaded()
        {
            Animation.Load();
            base.OnViewLoaded();
        }

        public void RunDemo()
        {
            try
            {
                drivingModel.RotateScale = Rota;
                drivingModel.MoveScale = Move;
                drivingModel.ActionName = Act;
                drivingModel.AxisName = SelectItem.AxisName;
                Animation.Action(drivingModel);
            }
            catch
            {
                MessageBox.Show("请选择轴参数");
            }
        }
    }
}
