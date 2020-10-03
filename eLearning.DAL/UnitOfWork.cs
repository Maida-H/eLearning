using eLearning.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eLearning.DAL
{
    public class UnitOfWork : IDisposable
    {
        protected eLearningContext _context;

        public UnitOfWork(eLearningContext context = null)
        {
            _context = context;
        }
        public eLearningContext Context { get { return _context; } }

        private IRepository<Grade> _grades;
        private IRepository<Professor> _professors;
        private IRepository<Student> _students;
        private IRepository<Section> _sections;
        private IRepository<Subject> _subjects;
        private IRepository<Notification> _notifications;
        private IRepository<StudentSubject> _studentSubjects;
        private IRepository<School> _schools;
        private IRepository<User> _users;



 

        public IRepository<Grade> Grades => _grades ?? (_grades = new Repository<Grade>(_context));
        public IRepository<Section> Sections => _sections ?? (_sections = new Repository<Section>(_context));
        public IRepository<Subject> Subjects => _subjects ?? (_subjects = new Repository<Subject>(_context));
        public IRepository<Student> Students => _students ?? (_students = new Repository<Student>(_context));
        public IRepository<Professor> Professors => _professors ?? (_professors = new Repository<Professor>(_context));
        public IRepository<StudentSubject> StudentSubjects => _studentSubjects ?? (_studentSubjects = new Repository<StudentSubject>(_context));
        public IRepository<User> Users => _users ?? (_users = new Repository<User>(_context));
        public IRepository<Notification> Notifications => _notifications ?? (_notifications = new Repository<Notification>(_context));
        public IRepository<School> Schools => _schools ?? (_schools = new Repository<School>(_context));
        public int Save() => _context.SaveChanges();
        public void Dispose() => _context.Dispose();

    }
}
