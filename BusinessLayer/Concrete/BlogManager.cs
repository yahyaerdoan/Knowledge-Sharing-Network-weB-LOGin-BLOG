﻿using System;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        readonly IBlogDal _blogDal;
        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void Add(Blog blog)
        {
            _blogDal.Add(blog);
        }

        public void Delete(Blog blog)
        {
            _blogDal.Delete(blog);
        }

        public List<Blog> GetAll()
        {
            return _blogDal.GetAll();
        }

        public List<Blog> ListAll(Expression<Func<Blog, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetLastThreeBlogs()
        {
            return _blogDal.GetAll().Take(3).ToList();
        }

        public List<Blog> GetAllWithCategory()
        {
            return _blogDal.GetAllWithCategory();
        }

        public List<Blog> GetBlogListByWriterId(int id)
        {
            return _blogDal.ListAll(x => x.WriterId == id);
        }

        public Blog GetById(int id)
        {
            return _blogDal.GetById(id);
        }

        public List<Blog> GetListBlogById(int id)
        {
            return _blogDal.ListAll(x => x.BlogId == id);
        }

        public void Update(Blog blog)
        {
            _blogDal.Update(blog);
        }
    }
}
