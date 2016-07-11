﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using GenericMvcUtilities.Client;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Logging;

namespace GenericMvcUtilities.Test.Lib.Fixtures
{
	public interface ITestFixture
	{
		HttpClient Client { get; }

		AuthClient AuthClient { get; }

		LoggerFactory LogFactory { get; }

		string AuthCookie { get; }
	}
}