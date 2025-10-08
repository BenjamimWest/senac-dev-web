using MeuCorre.Domain.Entities;
using MeuCorre.Domain.Enums;
using Microsoft.EntityFrameworkCore;

ModelBuilder.Entity<Categoria>().HasData(
    new
    {
        Id = Guid.Parse("11111111-1111-1111-1111-111111111111"),
        Nome = "Moradia",
        Descricao = "Despesas relacionadas à casa e moradia (aluguel, condomínio, contas)",
        Cor = "#BEE3F8",
        Icone = "🏠",
        TipoTransacao = TipoTransacao.Despesa,
        UsuarioId = Guid.Parse("00000000-0000-0000-0000-000000000001")
    },
    new
    {
        Id = Guid.Parse("22222222-2222-2222-2222-222222222222"),
        Nome = "Lazer",
        Descricao = "Despesas com entretenimento e lazer (cinema, viagens, hobbies)",
        Cor = "#C3FBD8",
        Icone = "🎉",
        TipoTransacao = TipoTransacao.Despesa,
        UsuarioId = Guid.Parse("00000000-0000-0000-0000-000000000001")
    },
    new
    {
        Id = Guid.Parse("33333333-3333-3333-3333-333333333333"),
        Nome = "Salário",
        Descricao = "Receitas provenientes do trabalho (salário, bônus, comissões)",
        Cor = "#FDE68A",
        Icone = "💼",
        TipoTransacao = TipoTransacao.Receita,
        UsuarioId = Guid.Parse("00000000-0000-0000-0000-000000000001")
    },
    new
    {
        Id = Guid.Parse("44444444-4444-4444-4444-444444444444"),
        Nome = "Investimentos",
        Descricao = "Receitas provenientes de investimentos (juros, dividendos, vendas de ativos)",
        Cor = "#E9D5FF",
        Icone = "📈",
        TipoTransacao = TipoTransacao.Receita,
        UsuarioId = Guid.Parse("00000000-0000-0000-0000-000000000001")
    },
    new
    {
        Id = Guid.Parse("55555555-5555-5555-5555-555555555555"),
        Nome = "Alimentação",
        Descricao = "Despesas com comida e bebida (supermercado, restaurantes, lanches)",
        Cor = "#FCA5A5",
        Icone = "🍔",
        TipoTransacao = TipoTransacao.Despesa,
        UsuarioId = Guid.Parse("00000000-0000-0000-0000-000000000001")
    },
    new
    {
        Id = Guid.Parse("66666666-6666-6666-6666-666666666666"),
        Nome = "Transporte",
        Descricao = "Despesas com transporte (combustível, transporte público, manutenção do veículo)",
        Cor = "#A7F3D0",
        Icone = "🚗",
        TipoTransacao = TipoTransacao.Despesa,
        UsuarioId = Guid.Parse("00000000-0000-0000-0000-000000000001")
    },
    new
    {
        Id = Guid.Parse("77777777-7777-7777-7777-777777777777"),
        Nome = "Educação",
        Descricao = "Despesas com educação (mensalidades, cursos, livros)",
        Cor = "#FBBF24",
        Icone = "🎓",
        TipoTransacao = TipoTransacao.Despesa,
        UsuarioId = Guid.Parse("00000000-0000-0000-0000-000000000001")
    },
    new
    {
        Id = Guid.Parse("88888888-8888-8888-8888-888888888888"),
        Nome = "Saúde",
        Descricao = "Despesas com saúde (planos de saúde, medicamentos, consultas)",
        Cor = "#F87171",
        Icone = "💊",
        TipoTransacao = TipoTransacao.Despesa,
        UsuarioId = Guid.Parse("00000000-0000-0000-0000-000000000001")
    },
    new
    {
        Id = Guid.Parse("99999999-9999-9999-9999-999999999999"),
        Nome = "Outros",
        Descricao = "Despesas e receitas diversas que não se encaixam em outras categorias",
        Cor = "#D1D5DB",
        Icone = "🔖",
        TipoTransacao = TipoTransacao.Despesa,
        UsuarioId = Guid.Parse("00000000-0000-0000-0000-000000000001")
    },
    new
    {
        Id = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
        Nome = "Freelance",
        Descricao = "Receitas provenientes de trabalhos freelance ou autônomos",
        Cor = "#34D399",
        Icone = "🖋️",
        TipoTransacao = TipoTransacao.Receita,
        UsuarioId = Guid.Parse("00000000-0000-0000-0000-000000000001")
    },
    new
    {
        Id = Guid.Parse("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
        Nome = "Doações",
        Descricao = "Despesas com doações para caridade ou causas sociais",
        Cor = "#60A5FA",
        Icone = "🎁",
        TipoTransacao = TipoTransacao.Despesa,
        UsuarioId = Guid.Parse("00000000-0000-0000-0000-000000000001")
    },
    new
    {
        Id = Guid.Parse("cccccccc-cccc-cccc-cccc-cccccccccccc"),
        Nome = "Roupas",
        Descricao = "Despesas com vestuário e acessórios",
        Cor = "#FBBF24",
        Icone = "👗",
        TipoTransacao = TipoTransacao.Despesa,
        UsuarioId = Guid.Parse("00000000-0000-0000-0000-000000000001")
    },
    new
    {
        Id = Guid.Parse("dddddddd-dddd-dddd-dddd-dddddddddddd"),
        Nome = "Presentes",
        Descricao = "Despesas com presentes para ocasiões especiais",
        Cor = "#F472B6",
        Icone = "🎁",
        TipoTransacao = TipoTransacao.Despesa,
        UsuarioId = Guid.Parse("00000000-0000-0000-0000-000000000001")
    },
    new
    {
        Id = Guid.Parse("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
        Nome = "Impostos",
        Descricao = "Despesas com impostos e taxas governamentais",
        Cor = "#9CA3AF",
        Icone = "🏛️",
        TipoTransacao = TipoTransacao.Despesa,
        UsuarioId = Guid.Parse("00000000-0000-0000-0000-000000000001")
    },
    new
    {
        Id = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff"),
        Nome = "Bônus",
        Descricao = "Receitas extras como bônus ou prêmios",
        Cor = "#34D399",
        Icone = "🏆",
        TipoTransacao = TipoTransacao.Receita,
        UsuarioId = Guid.Parse("00000000-0000-0000-0000-000000000001")
    },
    new
    {
        Id = Guid.Parse("12121212-1212-1212-1212-121212121212"),
        Nome = "Transferências",
        Descricao = "Movimentações de dinheiro entre suas próprias contas",
        Cor = "#A78BFA",
        Icone = "🔄",
        TipoTransacao = TipoTransacao.Transferencia,
        UsuarioId = Guid.Parse("00000000-0000-0000-0000-000000000001")
    },
    new
    {
        Id = Guid.Parse("13131313-1313-1313-1313-131313131313"),
        Nome = "Serviços",
        Descricao = "Despesas com serviços como internet, telefone, TV a cabo",
        Cor = "#FBBF24",
        Icone = "📡",
        TipoTransacao = TipoTransacao.Despesa,
        UsuarioId = Guid.Parse("00000000-0000-0000-0000-000000000001")
    },
    new
    {
        Id = Guid.Parse("14141414-1414-1414-1414-141414141414"),
        Nome = "Cuidados Pessoais",
        Descricao = "Despesas com cuidados pessoais como salão de beleza, academia",
        Cor = "#F472B6",
        Icone = "💇‍♂️",
        TipoTransacao = TipoTransacao.Despesa,
        UsuarioId = Guid.Parse("00000000-0000-0000-0000-000000000001")
    },
    new
    {
        Id = Guid.Parse("15151515-1515-1515-1515-151515151515"),
        Nome = "Animais de Estimação",
        Descricao = "Despesas com cuidados e alimentação de animais de estimação",
        Cor = "#A3E635",
        Icone = "🐾",
        TipoTransacao = TipoTransacao.Despesa,
        UsuarioId = Guid.Parse("00000000-0000-0000-0000-000000000001")
    },
    new
    {
        Id = Guid.Parse("16161616-1616-1616-1616-161616161616"),
        Nome = "Assinaturas",
        Descricao = "Despesas com assinaturas de serviços como streaming, revistas",
        Cor = "#60A5FA",
        Icone = "📺",
        TipoTransacao = TipoTransacao.Despesa,
        UsuarioId = Guid.Parse("00000000-0000-0000-0000-000000000001")
    }
   
);
