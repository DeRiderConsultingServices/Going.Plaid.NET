﻿using System.Text.Json.Serialization;

namespace Going.Plaid.Institution
{
	/// <summary>
	/// Represents a response from plaid's '<c>/institutions/get_by_id</c>' endpoints. The '<c>/institutions/get_by_id</c>' endpoint to retrieve a <see cref="Entity.Institution"/> with the specified id.
	/// </summary>
	/// <seealso cref="Going.Plaid.ResponseBase" />
	public record SearchByIdResponse : ResponseBase
	{
		/// <summary>
		/// The institution returned from the server.
		/// </summary>
		[JsonPropertyName("institution")]
		public Entity.Institution Institution { get; init; } = null!;
	}
}
