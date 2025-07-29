// -----------------------------------------------------------------------------
// 📄 Classe: Blogs
// 📦 Namespace: Aviator.Domain.Entities
//
// 🧠 O que ela representa:
// Essa classe é uma *entidade* que representa um blog no domínio da aplicação.
// É usada para mapear os dados de um blog que serão salvos ou lidos do banco.
//
// 🧱 Propriedades:
// - Id: identificador único do blog.
// - Name: nome do blog.
// - Description: descrição do conteúdo do blog.
// - Author: nome do autor do blog.
//
// 🧪 Onde pode ser usada:
// - No Entity Framework como uma entidade da tabela "Blogs".
// - Em repositórios para buscar, salvar ou atualizar dados de blogs.
// -----------------------------------------------------------------------------

namespace Aviator.Domain.Entities;

public class Blogs
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Author { get; set; }
}