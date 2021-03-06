﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesLayer;
using System.Collections;
using System.Transactions;
using System.Data.SqlClient;
using System.Data;

namespace DAL.Repositories
{
    public class RolRepository : IRepository<Rol>
    {

        private List<IEntity> _insertItems;
        private List<IEntity> _deleteItems;
        private List<IEntity> _updateItems;

        public RolRepository()
        {
            _insertItems = new List<IEntity>();
            _deleteItems = new List<IEntity>();
            _updateItems = new List<IEntity>();
        }

        public void Insert(Rol entity)
        {
            _insertItems.Add(entity);
        }

        public void Delete(Rol entity)
        {
        }

        public void Update(Rol entity)
        {
        }


        public Rol GetById(int id)
        {
            Rol Rol = null;
            return Rol;
        }

        public void Save()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    if (_insertItems.Count > 0)
                    {
                        foreach (Rol objRol in _insertItems)
                        {
                            InsertRol(objRol);
                        }
                    }
                }
                catch (TransactionAbortedException ex)
                {

                }
                catch (ApplicationException ex)
                {

                }
                finally
                {
                    Clear();
                }

            }
        }

        public void Clear()
        {
            _insertItems.Clear();
            _deleteItems.Clear();
            _updateItems.Clear();
        }

        public IEnumerable<Rol> GetAll()
        {
            List<Rol> pRol = null;
            SqlCommand cmd = new SqlCommand();
            DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "PaObtenerRoles");

            if (ds.Tables[0].Rows.Count > 0)
            {
                pRol = new List<Rol>();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    pRol.Add(new Rol
                    {
                        Nombre = dr["Nombre"].ToString(),
                        Descripcion = dr["Descripcion"].ToString(),
                    });
                }
            }

            return pRol;
        }

        private void InsertRol(Rol objRol)
        {

            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@Nombre", objRol.Nombre));
                cmd.Parameters.Add(new SqlParameter("@Descripcion", objRol.Descripcion));

                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "PaRegistrarRol");

            }
            catch (Exception ex)
            {

            }

        }

        private void UpdateRol(Rol objRol)
        {
            try
            {
            }
            catch (Exception ex)
            {

            }
        }

        private void DeleteRol(Rol objRol)
        {
            try
            {
            }
            catch (SqlException ex)
            {
                //logear la excepcion a la bd con un Exception
                //throw new DataAccessException("Ha ocurrido un error al eliminar un usuario", ex);

            }
            catch (Exception ex)
            {
                //logear la excepcion a la bd con un Exception
                //throw new DataAccessException("Ha ocurrido un error al eliminar un usuario", ex);
            }
        }

    }
}