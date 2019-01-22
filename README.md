# AzureWorkItemUpdatesDeserialize
Deserialize WorkItemsUpdates API from Azure DevOps. Using the article by John Thiriet on efficient API calls https://johnthiriet.com/efficient-api-calls/ I have created this simple code snippet that pulls back the update history of an AzureDevOps WorkItem. Using the updates API https://docs.microsoft.com/en-us/rest/api/azure/devops/wit/updates/list?view=azure-devops-rest-5.0 you can get a list of all of the updates that have happened to a work item. This is useful however some WorkItems can have a lot of updates and while a single WorkItem might not take a long time if you wanted to pull data on several hundred WorkItems we should be able to start processing the Update items immediately. 

I was able to test the solution to prove that it works from the standpoint of pulling and deserializing from a stream but I was unable to take the time to prove that the async was actually allowing the stream the ability to deserialize before the full payload was availabe. 

Azure DevOps API Deserialize From Stream
