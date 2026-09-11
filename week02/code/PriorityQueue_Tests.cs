using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add three items with different priorities and remove them from the queue.
    // Expected Result: The item with the highest priority should be returned first.
    // Defect(s) Found: None. Test passed.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("High", 3);
        priorityQueue.Enqueue("Medium", 2);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("High", result);
    }

    [TestMethod]
    // Scenario: Add three items where two items have the same highest priority.
    // Expected Result: The first items added with the highest priority should be returned first.
    // Defect(s) Found: The queue does not correctly maintain FIFO order when items have the same priority.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("First", 3);
        priorityQueue.Enqueue("Second", 3);
        priorityQueue.Enqueue("Third", 1);

        var firstResult = priorityQueue.Dequeue();
        var secondResult = priorityQueue.Dequeue();


        Assert.AreEqual("First", firstResult);
        Assert.AreEqual("Second", secondResult);
    }

    // Add more test cases as needed below.

    [TestMethod]
    // Scenario: Try to remove an item from an empty prioprity queue.
    // Expected Result: An InvalidOperationException should be thrown with the message "The queue is empty."
    // Defect(s) Found: None. Test passed.
    public void TestPriorityQueue_Empty()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
    }
}