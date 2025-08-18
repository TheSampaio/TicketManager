<body>
  <h1>🎟️ TicketManager</h1>
  <p>
    A <strong>backend web application</strong> built with 
    <strong>ASP.NET Core</strong>, <strong>SQL Server</strong>, and 
    <strong>Entity Framework Core</strong>.  
    It follows good practices and REST principles, and integrates 
    <strong>Scalar</strong> for API documentation and testing.  
    Inspired by ticketing platforms like 
    <a href="https://glpi-project.org/" target="_blank">GLPI</a> 
    and <a href="https://www.zenvia.com/" target="_blank">Zenvia</a>.  
    <br /><br />
    ⚠️ A <strong>Frontend</strong> is planned but not yet implemented.
  </p>

  <h2>📚 Table of Contents</h2>
  <ul>
    <li><a href="#features">Features</a></li>
    <li><a href="#project-structure">Project Structure</a></li>
    <li><a href="#tech-stack">Tech Stack</a></li>
    <li><a href="#getting-started">Getting Started</a></li>
    <li><a href="#api-documentation">API Documentation</a></li>
    <li><a href="#api-endpoints">API Endpoints</a></li>
    <li><a href="#license">License</a></li>
  </ul>

  <h2 id="features">✨ Features</h2>
  <ul>
    <li>RESTful API with full <strong>CRUD</strong> for tickets</li>
    <li>Built with <strong>ASP.NET Core</strong> and <strong>EF Core</strong></li>
    <li>SQL Server database integration</li>
    <li>DTOs and Models for clean data management</li>
    <li>Scalar for API documentation and testing</li>
  </ul>

  <h2 id="project-structure">📂 Project Structure</h2>
  <pre><code>Backend
│
├── Controllers
│   └── TicketController.cs
│
├── DTOs
│   ├── TicketPostRequest.cs
│   ├── TicketPostResponse.cs
│   └── TicketPutRequest.cs
│
├── Data
│   └── AppDbContext.cs
│
├── Migrations
│   └── ...
│
├── Models
│   └── TicketModel.cs
│
├── Properties
│   └── launchSettings.json
│
├── .gitignore
├── Backend.csproj
├── Backend.sln
├── Program.cs
├── appsettings.Development.json
├── appsettings.json
├── LICENSE
└── README.md
</code></pre>
<p><em><strong>Note:</strong> EF Core migrations are stored in the <code>Migrations/</code> folder.</em></p>

  <h2 id="tech-stack">🧰 Tech Stack</h2>
  <ul>
    <li><strong>Backend:</strong> ASP.NET Core 9 Web API</li>
    <li><strong>Database:</strong> Microsoft SQL Server</li>
    <li><strong>ORM:</strong> Entity Framework Core 9.0.8</li>
    <li><strong>Documentation:</strong> Scalar (OpenAPI)</li>
  </ul>

  <h2 id="getting-started">🚀 Getting Started</h2>

  <h3 id="prerequisites">🔧 Prerequisites</h3>
  <ul>
    <li><a href="https://dotnet.microsoft.com/en-us/download/dotnet/9.0" target="_blank" rel="noopener noreferrer">.NET 9 SDK</a></li>
    <li>Microsoft SQL Server (local or cloud-based)</li>
  </ul>

  <h3 id="backend-setup">🖥️ Backend Setup</h3>
  <ol>
    <li>Clone the repository:
      <pre><code>git clone https://github.com/your-username/TicketManager.git
cd TicketManager/Backend</code></pre>
    </li>
    <li>Update your connection string in <code>appsettings.json</code> under <code>DefaultConnection</code>.</li>
    <li>Run EF Core migrations (if needed):
      <pre><code>dotnet ef database update</code></pre>
    </li>
    <li>Run the backend:
      <pre><code>dotnet run</code></pre>
    </li>
    <li>The API will be available at:
      <br /><code>http://localhost:5000</code> or <code>https://localhost:5002</code>
    </li>
  </ol>

  <h2 id="api-documentation">📖 API Documentation</h2>
  <p>After running the backend, Scalar documentation is available at:</p>
  <ul>
    <li><code>http://localhost:5000/scalar</code></li>
    <li><code>https://localhost:5002/scalar</code></li>
  </ul>

  <h2 id="api-endpoints">📡 API Endpoints</h2>
  <table>
    <thead>
      <tr>
        <th>Method</th>
        <th>Endpoint</th>
        <th>Description</th>
        <th>Request Body Example</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td>GET</td>
        <td><code>/api/tickets</code></td>
        <td>Retrieve all tickets</td>
        <td>None</td>
      </tr>
      <tr>
        <td>POST</td>
        <td><code>/api/tickets</code></td>
        <td>Create a new ticket</td>
        <td>
          <pre><code>{
  "title": "Printer issue",
  "description": "Printer is not working",
  "requesterId": 1
}</code></pre>
        </td>
      </tr>
      <tr>
        <td>GET</td>
        <td><code>/api/tickets/{id}</code></td>
        <td>Retrieve ticket by ID</td>
        <td>None</td>
      </tr>
      <tr>
        <td>PUT</td>
        <td><code>/api/tickets/{id}</code></td>
        <td>Update ticket by ID</td>
        <td>
          <pre><code>{
  "title": "Updated ticket",
  "description": "Issue resolved",
  "requesterId": 1,
  "technicianId": 2,
  "completedAt": "2025-08-18T10:30:00Z"
}</code></pre>
        </td>
      </tr>
      <tr>
        <td>DELETE</td>
        <td><code>/api/tickets/{id}</code></td>
        <td>Delete ticket by ID</td>
        <td>None</td>
      </tr>
    </tbody>
  </table>

  <h2 id="license">📃 License</h2>
  <p>
    This project is licensed under the MIT License. See the <a href="LICENSE">LICENSE</a> file for details.
  </p>

  <hr />
  <p><em>💡 Contributions, issues, and suggestions are welcome!</em></p>
</body>
