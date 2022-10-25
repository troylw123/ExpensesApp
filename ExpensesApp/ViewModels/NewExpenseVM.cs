using ExpensesApp.Models;
using System;
using System.ComponentModel;

namespace ExpensesApp.ViewModels
{
    public class NewExpenseVM : INotifyPropertyChanged
    {
        private string _expenseName;
        public string ExpenseName
        {
            get { return _expenseName; }
            set
            {
                _expenseName = value;
                OnPropertyChanged("ExpenseName");
            }
        }

        private string _expenseDescription;
        public string ExpenseDescription
        {
            get { return _expenseDescription; }
            set
            {
                _expenseDescription = value;
                OnPropertyChanged("ExpenseDescription");
            }
        }

        private float _expenseAmount;
        public float ExpenseAmount
        {
            get { return _expenseAmount; }
            set
            {
                _expenseAmount = value;
                OnPropertyChanged("ExpenseAmount");
            }
        }

        private DateTime _expenseDate;
        public DateTime ExpenseDate
        {
            get { return _expenseDate; }
            set
            {
                _expenseDate = value;
                OnPropertyChanged("ExpenseDate");
            }
        }

        private string _expenseCategory;
        public string ExpenseCategory
        {
            get { return _expenseCategory; }
            set
            {
                _expenseCategory = value;
                OnPropertyChanged("ExpenseCategory");
            }
        }
        public NewExpenseVM()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public void InsertExpense()
        {
            Expense expense = new Expense()
            {
                Name = ExpenseName,
                Amount = ExpenseAmount,
                Category = ExpenseCategory,
                Date = ExpenseDate,
                Description = ExpenseDescription
            };

            Expense.InsertExpense(expense);
        }
    }
}
