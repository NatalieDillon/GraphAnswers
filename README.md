## Graph exercises

To start with we aregoing to look at how to represent a graph using an adjacency matrix or an adjacency list</br>
It has been assumed for the moment that the vertices will be a string</br>

1. Implement IGraph using an adjacency matrix. You will need a 2-Dimensional array to hold the edges. You could use a list of strings for the vertices</br>
2. Implement IGraph using an adjacency list. You might wish to use a dictionary of dictionaries for this.</br>
3. Test your code, there is some example test code in Program.cs. You may wish to add to this or to create your own unit tests</br>
4. Now create a text file with some example graph data (you might wish to look up some real data such as the travel times between different underground stations) and add code to upload this data into a graph and test it</br>
5. Extend your code for the adjacency list so that it is easy to specify an undirected graph. When you add a new edge to an undirected graph the edge should be added in both directions. When a graph is unweighted
(i.e there are no edge weights other than one) then the display method should be updated not to display the weights.
6. Add a depth first search using recursion to the adjacency list graph. To verify that it works use test data from the graph in GraphExercises_2.pptx. It will probably be fastest to use a HashSet (like a
dictionary but only with keys) for the list of visited vertices. However if you want to be sure that the visit order is preserved then you will need to use a List as well.
7. Write another method for depth first search but use a stack
8. Write a method for breadth first search. It will be the same as the depth first search with a stack but it will use a queue.
