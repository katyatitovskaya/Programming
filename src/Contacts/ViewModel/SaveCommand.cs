﻿using Contacts.Model.Services;
using Contacts.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace Contacts.ViewModel
{
    /// <summary>
    /// Хранит информации о команде сохранения объекта. 
    /// </summary>
    public class SaveCommand: ICommand
    {
        /// <summary>
        /// Привязка данных, содержащихся в <see cref="MainVM"/>
        /// </summary>
        public MainVM DataContext { get; set; }

        /// <summary>
        /// Событие, вызываемое при изменении условий 
        /// возможности вызыва команды. 
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
        /// Определяет метод при вызове команды <see cref="SaveCommand"/>. 
        /// </summary>
        public void Execute(object? parameter)
        {
            var fullName = DataContext.SelectedContact.FullName;
            var phoneNumber = DataContext.SelectedContact.PhoneNumber;
            var email = DataContext.SelectedContact.Email;
            var contacts = new ObservableCollection<Contact>() 
            { new Contact(fullName, phoneNumber, email) };
            ContactSerializer.SaveToFile(contacts);
        }

        /// <summary>
        /// Создает объект типа <see cref="SaveCommand"/>. 
        /// </summary>
        /// <param name="dataContext">Данные хранящиеся 
        /// в <see cref="MainVM"/>.  </param>
        public SaveCommand(MainVM dataContext)
        {
            DataContext = dataContext;
        }
    }
}