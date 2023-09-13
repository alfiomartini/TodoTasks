# TodoTasks App

## Description

- This is a simple Todo App created to test some techniques used in the Blazor Framework. This application renders a initial list of tasks from a json file using an http client. One can insert new tasks, check them as completed and remove existing ones.
- Global state is modeled as a singleton service and injected in whatever component is needed.

## Branches

- _master_: uses singleton services to model global state
- _cascading_: uses cascading elements to model global state (not recommended)

## Further Developments

- Use a json server to provide data for the app
- Implement additional http methods in the repository
- Add unit tests
- Style using tailwind
- Use `CascadingValue` component to implement global memory

## How to Run this app (development mode)

- run the command `dotnet watch run`

This project was created by running `dotnet new blazorwasm -o TodoTasks`
