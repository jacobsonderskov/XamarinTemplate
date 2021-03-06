using Cirrious.MvvmCross.ViewModels;

namespace XamarinTemplate.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
		private string _hello = "Hello MvvmCross";
        public string Hello
		{ 
			get { return _hello; }
			set { _hello = value; RaisePropertyChanged(() => Hello); }
		}
    }
}
