namespace TGC.Core.SceneLoader
{
    /// <summary>
    ///     Interfaz generica para renderizar objetos
    /// </summary>
    public interface IRenderObject
    {
        /// <summary>
        ///     Habilita el renderizado con AlphaBlending para los modelos
        ///     con textura o colores por v�rtice de canal Alpha.
        ///     Por default est� deshabilitado.
        /// </summary>
        bool AlphaBlendEnable { get; set; }

        /// <summary>
        ///     Inicializacion del objeto.
        /// </summary>
        //void Init();

        /// <summary>
        ///     Renderiza el objeto.
        /// </summary>
        void Render();

        /// <summary>
        ///     Libera los recursos del objeto.
        /// </summary>
        void Dispose();
    }
}