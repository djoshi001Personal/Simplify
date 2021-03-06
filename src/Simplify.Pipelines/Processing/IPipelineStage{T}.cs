﻿namespace Simplify.Pipelines.Processing
{
	/// <summary>
	/// Represent pipeline stage
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface IPipelineStage<in T>
	{
		/// <summary>
		/// Executes the stage.
		/// </summary>
		/// <param name="args">The arguments.</param>
		/// <returns></returns>
		bool Execute(T args);
	}
}