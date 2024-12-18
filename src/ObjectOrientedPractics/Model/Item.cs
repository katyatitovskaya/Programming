﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит информацию о товаре. 
    /// </summary>
    public class Item: ICloneable, IEquatable<Item>, IComparable<Item>
    {
        /// <summary>
        /// Название товара. 
        /// </summary>
        private string _name;
       
        
        /// <summary>
        /// Описание товара. 
        /// </summary>
        private string _info; 

        /// <summary>
        /// Цена товара. 
        /// </summary>
        private double _price;

        /// <summary>
        /// Возвращает индивидуальный идентификатор товара. 
        /// </summary>
        public int Id { get; }


        /// <summary>
        /// Возвращает и задает название товара. 
        /// Должно быть не длиннее 200 символов. 
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                Services.ValueValidator.AssertStringOnLength(value, 200, nameof(Name));
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задает описание товара. 
        /// Должно быть не длиннее 1000 символов.  
        /// </summary>
        public string Info
        {
            get => _info;
            set
            {
                Services.ValueValidator.AssertStringOnLength(value, 1000, nameof(Info));
                _info = value;
            }
        }

        /// <summary>
        /// Возвращает и задает цену товара. 
        /// Не должна превышать 100 000. 
        /// </summary>
        public double Price
        {
            get => _price;
            set
            {
                if (value.CompareTo(10000) == -1 && value.CompareTo(0)>=0)
                {
                    _price = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        /// <summary>
        /// Возвращает и задает категорию товара. 
        /// </summary>
        public Category Category { get; set; }

        /// <inheritdoc cref="ICloneable"/>
        public object Clone()
        {
            return new Item(Name, Info, Price, Category);
        }
        
        /// <inheritdoc cref="IEquatable{T}.Equals(T?)"/>
        public bool Equals(Item other)
        {
            if(other == null)
            {
                return false;
            }
            return this.Id == other.Id;
        }

        /// <inheritdoc cref="IComparable{T}.CompareTo(T?)"/>
        public int CompareTo(Item other)
        {
            if(other == null)
            {
                return 1;
            }
            return this.Price.CompareTo(other.Price);
        }

        /// <summary>
        /// Создает объект класса <see cref="Item"/>. 
        /// </summary>
        public Item()
        {
            Id = Services.IdGenerator.GetNextID();
        }

        /// <summary>
        /// Создает объект класса <see cref="Item"/>. 
        /// </summary>
        /// <param name="name">Название. Должно быть короче 200 символов. </param>
        /// <param name="info">Описание. Должно быть короче 1000 символов. </param>
        /// <param name="price">Цена. Должна быть меньше 100 000.</param>
        /// <param name="category">Категория. </param>
        public Item(string name, string info, double price, Category category)
        {
            Name = name;
            Info = info;
            Price = price;
            Id = Services.IdGenerator.GetNextID();
            Category = category;
        }
    }
}
