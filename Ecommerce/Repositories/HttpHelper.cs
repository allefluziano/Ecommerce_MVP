﻿using Ecommerce.Interfaces;
using Ecommerce.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace Ecommerce.Repositories
{
    public class HttpHelper : IHttpHelper
    {
        private readonly IHttpContextAccessor contextAccessor;
        public IConfiguration Configuration { get; }

        public HttpHelper(IHttpContextAccessor contextAccessor, IConfiguration configuration)
        {
            this.contextAccessor = contextAccessor;
            Configuration = configuration;
        }

        public int? GetPedidoId()
        {
            return contextAccessor.HttpContext.Session.GetInt32("pedidoId");
        }

        public void SetPedidoId(int pedidoId)
        {
            contextAccessor.HttpContext.Session.SetInt32("pedidoId", pedidoId);
        }

        public void ResetPedidoId()
        {
            contextAccessor.HttpContext.Session.Remove("pedidoId");
        }

        public void SetCadastro(Cadastro cadastro)
        {
            string json = JsonConvert.SerializeObject(cadastro.GetClone());
            contextAccessor.HttpContext.Session.SetString("cadastro", json);
        }

        public Cadastro GetCadastro()
        {
            string json = contextAccessor.HttpContext.Session.GetString("cadastro");
            if (string.IsNullOrWhiteSpace(json))
                return new Cadastro();

            return JsonConvert.DeserializeObject<Cadastro>(json);
        }
    }
}
