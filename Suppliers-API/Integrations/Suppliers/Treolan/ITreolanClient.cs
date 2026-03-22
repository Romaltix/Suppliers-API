namespace Suppliers_API.Integrations.Suppliers.Treolan
{
	/// <summary>
	/// Контракт клиента для работы с API Treolan.
	/// Определяет, какие операции мы можем выполнять.
	/// </summary>
	public interface ITreolanClient
	{
		/// <summary>
		/// Получить токен авторизации Treolan.
		/// </summary>
		Task<string> GetTokenAsync(CancellationToken cancellationToken = default);
	}
}
