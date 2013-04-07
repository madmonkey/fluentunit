// --------------------------------------------------------------------------------------------------------------------
// <copyright file="INHibernateHelper.cs" company="Bitwise">
//   
// </copyright>
// <summary>
//   SessionFactory interface
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BitWise.Common.Data
{
	using NHibernate;

    /// <summary>SessionFactory interface</summary>
    public interface INHibernateHelper
	{
        /// <summary>The main method for spinning up a session instance.</summary>
        /// <returns>ISessionFactory implementation</returns>
        ISessionFactory CreateSessionFactory();
	}
}