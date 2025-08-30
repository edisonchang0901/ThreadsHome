namespace ThreadsHome.InfraStructure.DynamoDbUtil.Operations
{
    /// <summary>
    /// Repository �u�t�����A�Ω�إ߯S�w������ Repository
    /// </summary>
    public interface IRepositoryFactory
    {
        /// <summary>
        /// �إ߫��w������ Repository
        /// </summary>
        /// <typeparam name="T">��������</typeparam>
        /// <returns>Repository ���</returns>
        IRepository<T> CreateRepository<T>() where T : class;
        
        /// <summary>
        /// �إ߫��w��������Ū Repository
        /// </summary>
        /// <typeparam name="T">��������</typeparam>
        /// <returns>��Ū Repository ���</returns>
        IReadOnlyRepository<T> CreateReadOnlyRepository<T>() where T : class;
    }
    
    /// <summary>
    /// ��Ū Repository ����
    /// </summary>
    /// <typeparam name="T">��������</typeparam>
    public interface IReadOnlyRepository<T> : 
        IReadOperations<T>, 
        IQueryOperations<T>
        where T : class
    {
        /// <summary>
        /// �ˬd���جO�_�s�b
        /// </summary>
        Task<bool> ExistsAsync(object id, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// �ˬd���جO�_�s�b�]�ƦX��^
        /// </summary>
        Task<bool> ExistsAsync(object hashKey, object rangeKey, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// ���o�����`��
        /// </summary>
        Task<int> CountAsync(CancellationToken cancellationToken = default);
    }
}