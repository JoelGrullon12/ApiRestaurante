﻿using ApiRestaurante.Core.Application.DTOs.User;
using ApiRestaurante.Core.Application.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace ApiRestaurante.Presentation.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginRequest request)
        {
            return Ok(await _accountService.LoginAsync(request));
        }

        [Authorize(Roles ="Admin,SuperAdmin")]
        [HttpPost("RegisterWaiter")]
        public async Task<IActionResult> RegisterWaiter(RegisterRequest request)
        {
            try
            {
                var user=await _accountService.RegisterWaiterAsync(request);
                if (user == null)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
                return NoContent();
            }catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [Authorize(Roles ="Admin,SuperAdmin")]
        [HttpPost("RegisterAdmin")]
        public async Task<IActionResult> RegisterAdminAsync(RegisterRequest request)
        {
            try
            {
                var user = await _accountService.RegisterAdminAsync(request);
                if (user == null)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
