﻿// Copyright 2019 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace Google.Cloud.Redis.V1.Snippets
{
    using Google.LongRunning;
    using System.Threading.Tasks;

    public class CloudRedisClientSnippets
    {
        /// <summary>Snippet for FailoverInstanceAsync</summary>
        public async Task FailoverInstanceAsync()
        {
            // Snippet: FailoverInstanceAsync(InstanceName,FailoverInstanceRequest.Types.DataProtectionMode,CallSettings)
            // Additional: FailoverInstanceAsync(InstanceName,FailoverInstanceRequest.Types.DataProtectionMode,CancellationToken)
            // Create client
            CloudRedisClient cloudRedisClient = await CloudRedisClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName name = new InstanceName("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            FailoverInstanceRequest.Types.DataProtectionMode dataProtectionMode = FailoverInstanceRequest.Types.DataProtectionMode.Unspecified;
            // Make the request
            Operation<Instance, OperationMetadata> response =
                await cloudRedisClient.FailoverInstanceAsync(name, dataProtectionMode);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse =
                await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse =
                await cloudRedisClient.PollOnceFailoverInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for FailoverInstance</summary>
        public void FailoverInstance()
        {
            // Snippet: FailoverInstance(InstanceName,FailoverInstanceRequest.Types.DataProtectionMode,CallSettings)
            // Create client
            CloudRedisClient cloudRedisClient = CloudRedisClient.Create();
            // Initialize request argument(s)
            InstanceName name = new InstanceName("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            FailoverInstanceRequest.Types.DataProtectionMode dataProtectionMode = FailoverInstanceRequest.Types.DataProtectionMode.Unspecified;
            // Make the request
            Operation<Instance, OperationMetadata> response =
                cloudRedisClient.FailoverInstance(name, dataProtectionMode);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse =
                response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse =
                cloudRedisClient.PollOnceFailoverInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
