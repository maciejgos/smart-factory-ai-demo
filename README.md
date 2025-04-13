# Smart Factory AI Demo

Smart Factory AI Demo is an innovative demonstration project designed to showcase how a multi-agent AI system can transform manufacturing operations. This project integrates predictive maintenance with a natural language Copilot interface, offering a cutting-edge solution for real-time equipment monitoring and decision-making on the factory floor.

## Overview

Modern manufacturing environments demand real-time insights and swift responses to machine anomalies. Smart Factory AI Demo addresses these challenges by simulating an end-to-end workflow where multiple autonomous agents collaborate to monitor, analyze, and act on machine health data. The system fuses:
- Predictive Maintenance: Detecting anomalies in real time using simulated sensor data.
- Human-Agent Collaboration: Empowering floor managers with a natural language interface for intelligent decision support.

This combination ensures that potential issues are quickly identified, analyzed, and resolved with optimal scheduling, thereby reducing unplanned downtime and preserving production quality.

Key Features
- **Real-Time Telemetry Simulation**: The system utilizes a Sensor Data Agent to stream synthetic telemetry (temperature, vibration, power draw, etc.) that mimics real-world manufacturing conditions.
- **Anomaly Detection**: The Anomaly Detection Agent monitors the telemetry and identifies abnormal patterns that might indicate a potential equipment failure, such as bearing wear or overheating.
- **Maintenance Planning**: A Maintenance Planner Agent analyzes detected anomalies and proposes optimal maintenance windows, weighing factors like production schedules and the severity of the issue.
- **Natural Language Copilot**: The Copilot Agent leverages modern LLMs (e.g., via Azure OpenAI or local LLMs) to provide a conversational interface for floor managers. This allows users to ask questions like *“What’s happening on Line 3?”* or *“Can maintenance wait until the end of the shift?”* and receive actionable insights instantly.
- **Executor Agent**:
Once the manager approves a maintenance plan, the Executor Agent updates schedules and coordinates the necessary actions to execute the plan.
- **Real-Time Dashboard & Visualization**: Built with Blazor and SignalR, the user interface offers an interactive dashboard displaying live telemetry, agent status, and decision-making timelines in real time.

## Architecture

The demo is built on the .NET platform and adopts a modular, service-oriented architecture with clearly defined responsibilities for each agent:

![alt text](image.png)

This architecture ensures that data flows seamlessly between simulated sensor data, anomaly detection, planning, and the natural language interface, allowing for dynamic and interactive management of maintenance activities.

## Technology Stack [TBD]
- **Backend**: .NET 9
- **Real-Time Communication**: Microsoft Copilot
- **Artificial Intelligence**: Azure OpenAI or a local LLM integrated through Semantic Kernel
- **Data Simulation**: In-memory telemetry simulation and synthetic data generation 
- **Containerization & CI/CD**: Docker, GitHub Actions for streamlined deployment

### Use Cases & Benefits
- **Minimized Downtime**: Early detection of potential failures allows for scheduled maintenance, reducing costly unplanned stoppages.
- **Enhanced Decision-Making**: Natural language interactions with the Copilot agent help managers quickly understand the situation and make informed decisions.
- **Scalable & Modular**: The modular design paves the way for future extensions, such as integrating a more advanced data memory system or additional agents for complex decision-making.
- **Demonstration of Modern AI Integration**: Serves as a blueprint for deploying advanced AI agent systems in manufacturing environments, showcasing the synergy between predictive analytics and human oversight.