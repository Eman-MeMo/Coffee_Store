using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBisnessLayer.EntityManagers
{
	public sealed class SessionManager
	{
		private static readonly SessionManager instance = new SessionManager();

		public int UserID { get; private set; }

		private SessionManager() { }

		public static SessionManager Instance
		{
			get { return instance; }
		}

		public void SetUser(int userId)
		{
			UserID = userId;
		}

		public void ClearSession()
		{
			UserID = 0;
		}
	}
}