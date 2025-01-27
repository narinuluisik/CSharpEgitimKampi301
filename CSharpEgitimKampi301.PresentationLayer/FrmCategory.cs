﻿using CSharpEgitimKampi301.BusinessLayer.Abstract;
using CSharpEgitimKampi301.BusinessLayer.Concrete;
using CSharpEgitimKampi301.DataAccessLayer.EntityFramework;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.PresentationLayer
{
    public partial class FrmCategory : Form
    {
        private readonly ICategoryService _categoryService;

        public FrmCategory( )
        {
            _categoryService = new CategoryManager(new EfCategoryDal());
            InitializeComponent();
        }

    

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id=int.Parse(txtCategoryId.Text);
            var deletedValues = _categoryService.GetById(id);
            _categoryService.TDelete(deletedValues); 
            MessageBox.Show("Silme İşlemi Başarılı");
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var categoryValues = _categoryService.TGetAll(); 
            dataGridView1.DataSource = categoryValues;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
           
        private void btnAdd_Click(object sender, EventArgs e)
        {
          Category category =new Category();
            category.CategoryName = txtCategoryName.Text;
            category.CategoryStatus = true;
            MessageBox.Show("Ekleme İşlemi Başarılı");


        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryId.Text);
            var values= _categoryService.GetById(id);
            dataGridView1 .DataSource = values;

                         
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
                  Category category=new Category();
            int updatedId=int.Parse(txtCategoryId.Text);
            var updatedValue = _categoryService.GetById(updatedId);
            updatedValue.CategoryName = txtCategoryName.Text;
            updatedValue.CategoryStatus = true;
            _categoryService.TUpdate(updatedValue);
        }
    }
}
