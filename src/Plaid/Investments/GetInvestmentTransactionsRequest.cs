﻿using System;
using System.Text.Json.Serialization;
using Going.Plaid.Options;

namespace Going.Plaid.Investments
{
	/// <summary>
	/// Represents a request for plaid's '<c>/investments/transactions/get</c>' endpoint. The <c>/investments/transactions/get</c> endpoint allows developers to retrieve user-authorized transaction data for investment accounts. Transaction data is standardized across financial institutions, and InvestmentTransactions are related to Securities, which are included in the response and conform to the Security schema.
	/// </summary>
	/// <remarks>Due to the potentially large number of transactions associated with an <see cref="Entity.Item"/>, results are paginated. Manipulate the count and offset parameters in conjunction with the total_transactions response body field to fetch all available Transactions.</remarks>
	public class GetInvestmentTransactionsRequest : RequestBase
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetInvestmentTransactionsRequest"/> class.
		/// </summary>
		public GetInvestmentTransactionsRequest()
		{
			EndDate = DateTime.Now;
			StartDate = DateTime.Now.Subtract(TimeSpan.FromDays(30));
		}

		/// <summary>
		/// Gets or sets the start date.
		/// </summary>
		/// <value>The start date.</value>
		[JsonPropertyName("start_date")]
		public DateTime StartDate { get; set; }

		/// <summary>
		/// Gets or sets the end date.
		/// </summary>
		/// <value>The end date.</value>
		[JsonPropertyName("end_date")]
		public DateTime EndDate { get; set; }

		/// <summary>
		/// Gets or sets the pagination options.
		/// </summary>
		/// <value>The pagination options.</value>
		[JsonPropertyName("options")]
		public PaginationOptions? Options { get; set; }
	}
}
