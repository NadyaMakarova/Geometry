using ModelLibrary;
using ReactiveUI;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml.Linq;

namespace GeometryMakarova.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        #region Properties

        public double? R { get; set; }

        public double? TriangleS { get; set; }

        public double? CircleS { get; set; }

        public double? QuadS { get; set; }

        public double? TriangleA { get; set; }

        public double? QuadA { get; set; }

        public double? B { get; set; }

        public double? C { get; set; }

        public double? H { get; set; }

        public ICommand ReturnTriangleSCommand { get; }

        public ICommand ReturnCircleSCommand { get; }

        public ICommand ReturnQuadSCommand { get; }

        #endregion

        #region Constructor

        public MainWindowViewModel()
        {
            ReturnTriangleSCommand = ReactiveCommand.CreateFromTask(ReturnTriangleS);
            ReturnCircleSCommand = ReactiveCommand.CreateFromTask(ReturnCircleS);
            ReturnQuadSCommand = ReactiveCommand.CreateFromTask(ReturnQuadS);
        }

        #endregion

        #region Methods

        public async Task<bool?> ReturnTriangleS()
        {
            var parameters = new Parameters()
            {
                A = TriangleA,
                B = B,
                C = C
            };
            var triangle = new Triangle(parameters);
            TriangleS = triangle.ReturnS();
            this.RaisePropertyChanged(nameof(TriangleS));
            return null;
        }

        public async Task<bool?> ReturnCircleS()
        {
            var parameters = new Parameters()
            {
                R = R
            };
            var circle = new Circle(parameters);
            CircleS = circle.ReturnS();
            this.RaisePropertyChanged(nameof(CircleS));
            return null;
        }

        public async Task<bool?> ReturnQuadS()
        {
            var parameters = new Parameters()
            {
                A = QuadA,
                H = H
            };
            var figure = new Figure(parameters);
            QuadS = figure.ReturnS();
            this.RaisePropertyChanged(nameof(QuadS));
            return null;
        }

        #endregion
    }
}
