﻿using ExpensesApp.Models;
using System.Collections.ObjectModel;

namespace ExpensesApp.ViewModels
{

    public class ExpensesVM
    {
        public ObservableCollection<Expense> Expenses { get; set; }

        public ExpensesVM()
        {
            GetExpenses();
        }

        private void GetExpenses()
        {
            var expenses = Expense.GetExpenses();

            Expenses.Clear();

            foreach (var expense in expenses)
            {
                Expenses.Add(expense);
            }
        }
    }
}
