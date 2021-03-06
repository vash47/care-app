﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace CareApp.Models
{
	public class Usuario
	{
		public string Nombre { get; set; }
		public string Apellido { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public bool Tipo { get; set; }
		public string Cuidante { get; set; }
		public string Telefono { get; set; }

		[JsonIgnore]
		public string TelCuidante { get; set; }
		[JsonIgnore]
		public List<Usuario> Pacientes { get; set; }
		[JsonIgnore]
		public List<EmergencyConfig> Configuraciones { get; set; }
	}
}
