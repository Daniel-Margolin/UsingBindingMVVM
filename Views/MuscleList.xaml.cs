using UsingBinding.ViewModels;

namespace UsingBinding.Views
{
    public partial class MuscleList : ContentPage
    {
        public MuscleList()
        {
            MuscleListViewModel vm = new MuscleListViewModel();
            InitializeComponent();
            BindingContext = vm;
        }
    }
}