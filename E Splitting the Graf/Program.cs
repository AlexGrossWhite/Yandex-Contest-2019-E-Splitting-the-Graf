int[] graph = Console.ReadLine().Split(' ').Select(o => int.Parse(o)).ToArray(); // [0] ponts; [1] lines

List<int[]> lines = new List<int[]>();
for (int i = 0; i < graph[1]; i++)
{
     lines.Add(Console.ReadLine().Split(' ').Select(o => int.Parse(o)).ToArray());
}
int result = 0;
int minWeight = lines[0][2];
lines = lines.Select(o => o).OrderBy(o => o[0]).ToList();
for (int i = 1; i < lines.Count(); i++)
{
    if (lines[i - 1][0] == lines[i][0] && lines[i - 1][1] == lines[i][1])
    {
        if (minWeight > lines[i][2] && minWeight != 0) minWeight = lines[i][2];
    }
    else
    {
        if (lines[i][2] > result) result= lines[i][2];
        if (minWeight > result) result = minWeight;
        minWeight = 0;
    }
}
Console.WriteLine(result);