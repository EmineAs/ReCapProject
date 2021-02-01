using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryColorDal : IBaseDal<Color>
    {
        List<Color> _colors;
        public InMemoryColorDal()
        {
            _colors = new List<Color>
            {
                new Color {ColorId=1, ColorName="Siyah" },
                new Color {ColorId=2, ColorName="Beyaz" },
                new Color {ColorId=3, ColorName="Kırmızı" },

            };
        }

        public void Add(Color color)
        {

            _colors.Add(color);

            Console.WriteLine(color.ColorId + " nolu Renk Eklendi");
        }

        public void Delete(Color color)
        {
            Color colorToUpdate = _colors.SingleOrDefault(c => c.ColorId == color.ColorId);
            _colors.Remove(colorToUpdate);
            Console.WriteLine(color.ColorId + " nolu Renk Silindi");
        }

        public List<Color> GetAll()
        {
            return _colors;

        }

        public List<Color> GetById(int id)
        {
            return _colors.Where(c => c.ColorId == id).ToList();
        }

        public void Update(Color color)
        {
            Color colorToUpdate = _colors.SingleOrDefault(c => c.ColorId == color.ColorId);

            colorToUpdate.ColorName = color.ColorName;

            Console.WriteLine(color.ColorId + " nolu Renk Güncellendi");
        }
    }

    }
