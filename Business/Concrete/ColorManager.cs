using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager: IBaseService<Color>
    {
        IBaseDal<Color> _colorDal;


        public ColorManager(IBaseDal<Color> colorDal)
        {
            _colorDal = colorDal;

        }

        public List<Color> GetAll()
        {

            return _colorDal.GetAll();

        }
        public void Add(Color color) => _colorDal.Add(color);

        public void Update(Color color) => _colorDal.Update(color);

        public void Delete(Color color) => _colorDal.Delete(color);

        public List<Color> GetById(int id) => _colorDal.GetById(id);

    }
}
