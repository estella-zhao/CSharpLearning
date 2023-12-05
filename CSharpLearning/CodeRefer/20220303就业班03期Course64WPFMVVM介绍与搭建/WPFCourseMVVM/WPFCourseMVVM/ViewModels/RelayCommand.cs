using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFCourseMVVM.ViewModels
{
    /// <summary>
    /// 命令实现类
    /// </summary>
    public class RelayCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public Func<object, bool> canExecuteFunc;
        public Action<object> executeActions;
        public RelayCommand(Action<object> execute) : this(execute, null)
        {

        }
        public RelayCommand(Action<object> execute,Func<object,bool> canExecute)
        {
            executeActions = execute;
            canExecuteFunc = canExecute;
        }

       private void SHowInfo()
        {

        }

        //实现  能不能执行命令
        public bool CanExecute(object parameter)
        {
            if (canExecuteFunc != null)
                return canExecuteFunc(parameter);
            return true;
        }

        //实现  做什么
        public void Execute(object parameter)
        {
            if (executeActions != null)
                executeActions(parameter);
        }

        //执行CanExecuteChanged事件
        public void OnCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, new EventArgs());
        }
    }
}
