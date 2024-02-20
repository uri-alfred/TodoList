using TodoList.ViewModels;

namespace TodoList.Pages;

public partial class ToDoPage : ContentPage
{
	public ToDoPage(TodoviewModel mv)
	{
		InitializeComponent();
		BindingContext = mv;
	}
}