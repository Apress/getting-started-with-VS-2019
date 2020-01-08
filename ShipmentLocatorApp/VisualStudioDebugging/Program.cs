using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudioDebugging
{
    class Program
    {
        static void Main(string[] args)
        {
            var lstSubjects = new List<Subject>();
            for (var i = 0; i <= 5; i++)
            {
                var sub = new Subject();
                sub.SubjectCode = i;
                sub.SubjectDescription = $"Subject-{i}";
                lstSubjects.Add(sub);
            }

            var table = ConvertListToDataTable<Subject>(lstSubjects);
                        
            var student = new Student();
            if (student.HasSubjects())
            {

            }


        }

        static DataTable ConvertListToDataTable<T>(List<T> list)
        {
            var table = new DataTable();
            var properties = typeof(T).GetProperties();

            foreach (var prop in properties)
            {
                _ = table.Columns.Add(prop.Name);
            }

            foreach (var item in list)
            {
                var row = table.NewRow();
                foreach (var property in properties)
                {
                    var name = property.Name;
                    var value = property.GetValue(item, null);

                    row[name] = value;
                }
                table.Rows.Add(row);
            }

            return table;
        }
                       
        static string DisplayMessage()
        {
            return "Hello World";
        }
    }

    [DebuggerDisplay("Code: {SubjectCode, nq}, Subject: {SubjectDescription, nq}")]
    public class Subject
    {
        public int SubjectCode { get; set; }
        public string SubjectDescription { get; set; }
    }

    public class Student
    {
        private List<Subject> _subjectList;
        public Student() { }
        public Student(List<Subject> subjects) => _subjectList = subjects;
        public bool HasSubjects() => _subjectList != null;

        public List<Subject> StudentSubjects
        {
            get
            {
                if (_subjectList == null)
                {
                    _subjectList = new List<Subject>();
                }
                return _subjectList;
            }
        }
    }
}
