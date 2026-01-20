using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: The Enqueue function shall add an item (which contains both data and priority) to the back of the queue. 
    // The Dequeue function shall remove the function in the front of the queue.
    // Expected Result: The 3 priority items added to the list will be taken out in the same order they were added.
    // Defect(s) Found: The Dequeue() function was missing a line of code that removed the item from the list. If an item had 
    // the same priority as another the last added would be removed first instead of the first that was added. 
    // Once this was fixed the items were taken out in the same order they were added.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();


        var eggs = new PriorityItem("eggs", 1);
        var bread = new PriorityItem("bread", 1);
        var milk = new PriorityItem("milk", 1);


        priorityQueue.Enqueue(eggs.Value, eggs.Priority);
        priorityQueue.Enqueue(bread.Value, bread.Priority);
        priorityQueue.Enqueue(milk.Value, milk.Priority);

        Assert.AreEqual("eggs", priorityQueue.Dequeue());
        Assert.AreEqual("bread", priorityQueue.Dequeue());
        Assert.AreEqual("milk", priorityQueue.Dequeue());

    }

    [TestMethod]
    // Scenario: The Dequeue function shall remove the item with the highest priority and return its value. 
    // If there are more than one item with the highest priority, then the item closest to the front of the queue will be removed and its value returned.
    // Expected Result: the queue will dequeue the items in the order of crackers, cheese, ham and then butter. Ham was enqueued first so it will be pulled out before butter.
    // Defect(s) Found: The Dequeue() function wouldn't check the last item added in the queue since it was only looking through queue.Count -1, which would exclude the last item added.
    //Once that was corrected the test ran as expected.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        var ham = new PriorityItem("ham", 1);
        var cheese = new PriorityItem("cheese", 2);
        var butter = new PriorityItem("butter", 1);
        var crackers = new PriorityItem("crackers", 3);
        var chips = new PriorityItem("chips", 4);
        


        priorityQueue.Enqueue(ham.Value, ham.Priority);
        priorityQueue.Enqueue(cheese.Value, cheese.Priority);
        priorityQueue.Enqueue(crackers.Value, crackers.Priority);
        priorityQueue.Enqueue(butter.Value, butter.Priority);
        priorityQueue.Enqueue(chips.Value, chips.Priority);


        Assert.AreEqual("chips", priorityQueue.Dequeue());
        Assert.AreEqual("crackers", priorityQueue.Dequeue());
        Assert.AreEqual("cheese", priorityQueue.Dequeue());
        Assert.AreEqual("ham", priorityQueue.Dequeue());
        Assert.AreEqual("butter", priorityQueue.Dequeue());
        
    }


    [TestMethod]
    // Scenario: If the queue is empty, then an error exception shall be thrown. This exception should be an InvalidOperationException with a message of "The queue is empty."
    // Expected Result: An error will be thrown when attempting to dequeue an empty queue. The text of the error will include the message "The queue is empty."
    // Defect(s) Found: No defects found, the InvalidOperationException was thrown with the message "The queue is empty."
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
        }
        catch (InvalidOperationException result)
        {
            Assert.AreEqual("The queue is empty.", result.Message);
        }
    }

    // Add more test cases as needed below.
}