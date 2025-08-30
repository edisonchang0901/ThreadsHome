using Amazon.DynamoDBv2.DataModel;

namespace ThreadsHome.InfraStructure.DynamoDbUtil.Operations
{
    /// <summary>
    /// �զX�Ҧ� CRUD �ާ@������ Repository ����
    /// </summary>
    /// <typeparam name="T">��������</typeparam>
    public interface IRepository<T> : 
        IReadOperations<T>, 
        IWriteOperations<T>, 
        IUpdateOperations<T>,
        IDeleteOperations<T>, 
        IQueryOperations<T>,
        IBatchOperations<T>
        where T : class
    {
        // �i�H�b�o�̥[�J�S���զX�ާ@
        
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
        
        /// <summary>
        /// ���o�ŦX���󪺶����`��
        /// </summary>
        Task<int> CountAsync(List<ScanCondition> conditions, CancellationToken cancellationToken = default);
    }
}