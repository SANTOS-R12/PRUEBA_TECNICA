using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace PRUEBA_TECNICA
{
    class CDatos
    {
        dbSIHUACOOPEntities db;
        public void Create(CLIENTE cCliente)
        {
            try
            {
                using (db = new dbSIHUACOOPEntities())
                {
                    db.CLIENTE.Add(cCliente);
                    db.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        public List<CLIENTE> Read()
        {
            try
            {
                using (db=new dbSIHUACOOPEntities())
                {
                    return db.CLIENTE.ToList();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public void Update(CLIENTE cLIENTE)
        {
            try
            {
                using (db = new dbSIHUACOOPEntities())
                {
                    db.Entry(cLIENTE).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Delete(int cnodui)
        {
            
            try
            {
                using (db= new dbSIHUACOOPEntities())
                {

                    db.CLIENTE.Remove(db.CLIENTE.Single

                    (c => c.no_dui == cnodui));               
                   

                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public List<CLIENTE> buscardui(int cnodui)
        {
            try
            {
                using (db=new dbSIHUACOOPEntities())
                {
                    return db.CLIENTE.Where(c => c.no_dui == cnodui).ToList();
                   // return db.CLIENTE.Where(c => c.no_dui == Convert.ToString(cnodui)).ToList());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
