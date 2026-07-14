using Xunit;

public class TaskManagerTests
{
    [Fact]
    public void GetPendingTaskCount_ReturnsTwo()
    {
        var taskManager = new TaskManager();

        var result = taskManager.GetPendingTaskCount();

        Assert.Equal(2, result);
    }

    [Fact]
    public void GetCompletedTaskCount_ReturnsOne()
    {
        var taskManager = new TaskManager();

        var result = taskManager.GetCompletedTaskCount();

        Assert.Equal(1, result);
    }

    [Fact]
    public void GetNextTask_ReturnsReviewPullRequest()
    {
        var taskManager = new TaskManager();

        var result = taskManager.GetNextTask();

        Assert.Equal("Review pull request", result);
    }
}
