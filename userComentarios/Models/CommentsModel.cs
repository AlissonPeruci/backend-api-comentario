using System;

namespace userComentarios
{
    public class CommentsModel
    {
        
        public string nome_usuario { get; set; }

        public int key { get; set; }
        
        public string data { get; set; }
        
        public string comentario { get; set; }

        public int usuario_id { get; set; }
        

    }
}
