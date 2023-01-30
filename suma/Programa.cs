using System;
namespace suma
{
	interface IPrograma
	{
		public void RestarNumerosUI();
		public void SumarNumeros();
		public void DolarAPeso();
        public void IVACompra();
        public void AreaTriangulo();
    }

	public class Programa : Operaciones , IPrograma
    {
			
	}
}

