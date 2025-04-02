using M014.View;
using M014.ViewModel;

namespace M014;

class MessageBoxHelper
{
	public static void Show(ViewModelBase dataContext)
	{
		MainWindow mw = new()
		{
			DataContext = dataContext
		};
		mw.ShowDialog();
	}
}
