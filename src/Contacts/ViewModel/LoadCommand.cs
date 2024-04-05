using Contacts.Model.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Contacts.ViewModel
{
    /// <summary>
    /// Хранит информацию о команде выгрузки данных объекта. 
    /// </summary>
    public class LoadCommand: ICommand
    {
        /// <summary>
        /// Возвращает и задает текущий источник данных.
        /// </summary>
        public MainVM DataContext { get; set; }

        /// <summary>
        /// Событие, вызываемое при изменении условий возможности вызыва команды. 
        /// </summary>
        public event EventHandler CanExecuteChanged;

        /// <summary>
        /// Возвращает, может ли вызываться команда
        /// </summary>
        /// <returns>Может ли вызываться команда. </returns>
        public bool CanExecute(object? parameter)
        {
            return true;
        }

        /// <summary>
        /// Определяет метод при вызове команды <see cref="LoadCommand"/>. 
        /// </summary>
        public void Execute(object? parameter)
        {
            var contact = ContactSerializer.LoadFromFile();
            
        }

        /// <summary>
        /// Создает объект типа <see cref="LoadCommand"/>. 
        /// </summary>
        /// <param name="dataContext">Данные хранящиеся в <see cref="MainVM"/>. </param>
        public LoadCommand(MainVM dataContext)
        {
            DataContext = dataContext;
        }
    }
}
