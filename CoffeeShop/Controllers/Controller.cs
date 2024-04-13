using Microsoft.AspNetCore.Mvc;
using System;
using System.Net.Http;
using System.Collections.Generic;

[ApiController] 
[Route("store/")]
public class TasksController : ControllerBase
{
    private readonly IOrderManager _orderManager;
    public TasksController(IOrderManager orderManager)
    {
        _orderManager = orderManager;
    }

    [HttpGet("show")]
    public IActionResult GetAll()
    {
        return Ok(_orderManager.GetAllOrders());
    }

    [HttpPost("add")]
    public IActionResult GetId([FromBody] OrderTask task)
    {
        _orderManager.AddOrder(task);
        return Ok(_orderManager.GetAllOrders());
    }

    [HttpGet("delete/id")]
    public IActionResult DeleteId(int id)
    {
        _orderManager.DeleteOrder(id);
        return Ok("task was deleted");
    }
}