﻿using System;
using System.Diagnostics;
using System.Threading;

namespace Simplify.WindowsServices.IntegrationTests
{
	public class TaskProcessor1 : IDisposable
	{
		private static bool _isRunning;

		public TaskProcessor1(Dependency1 dependency1)
		{
		}

		public void Run()
		{
			if (_isRunning)
				throw new SimplifyWindowsServicesException("TaskProcessor1 is running a duplicate!");

			_isRunning = true;

			Trace.WriteLine("TaskProcessor1 launched");

			Thread.Sleep(5120);

			_isRunning = false;
		}

		public void Dispose()
		{
			Trace.WriteLine("TaskProcessor1 disposed");
		}
	}
}