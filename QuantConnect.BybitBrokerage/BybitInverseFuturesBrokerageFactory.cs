/*
 * QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
 * Lean Algorithmic Trading Engine v2.0. Copyright 2014 QuantConnect Corporation.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
*/

using QuantConnect.Data;
using QuantConnect.Packets;
using QuantConnect.Securities;
using QuantConnect.Interfaces;
using QuantConnect.Brokerages.Bybit.Models.Enums;

namespace QuantConnect.Brokerages.Bybit;

/// <summary>
/// Factory method to create Bybit inverse brokerage
/// </summary>
public class BybitInverseFuturesBrokerageFactory : BybitBrokerageFactory
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BybitInverseFuturesBrokerageFactory"/> class
    /// </summary>
    public BybitInverseFuturesBrokerageFactory() : base(typeof(BybitInverseFuturesBrokerage))
    {
    }

    /// <summary>
    /// Gets a brokerage model that can be used to model this brokerage's unique behaviors
    /// </summary>
    /// <param name="orderProvider">The order provider</param>
    public override IBrokerageModel GetBrokerageModel(IOrderProvider orderProvider) =>
        new BybitInverseFuturesBrokerageModel(AccountType.Margin);

    /// <summary>
    /// Creates a new BybitBrokerage instance
    /// </summary>
    /// <param name="apiKey">The api key</param>
    /// <param name="apiSecret">The api secret</param>
    /// <param name="apiUrl">The rest api url</param>
    /// <param name="wsUrl">The web socket base url</param>
    /// <param name="algorithm">The algorithm instance is required to retrieve account type</param>
    /// <param name="aggregator">The aggregator for consolidating ticks</param>
    /// <param name="job">The live job packet</param>
    /// <param name="vipLevel">Bybit VIP level</param>
    /// <returns>New BybitBrokerage instance</returns>
    protected override BybitBrokerage CreateBrokerage(string apiKey, string apiSecret, string apiUrl, string wsUrl, IAlgorithm algorithm,
        IDataAggregator aggregator, LiveNodePacket job, BybitVIPLevel vipLevel)
    {
        return new BybitInverseFuturesBrokerage(apiKey, apiSecret, apiUrl, wsUrl, algorithm, aggregator, job, vipLevel);
    }
}