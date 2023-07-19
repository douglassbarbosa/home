import Link from "next/link"
export default function NavBar() {
    return (
        <>
         <h1>Sistema: Gestão de Clientes</h1>
        <nav className="flex justify-between itens-center">
          <ul>
            <li>
              <Link href="../">HOME</Link>
            </li>
            <li>
              <Link href="../categorias">CATEGORIA CLIENTE</Link>
            </li>
          </ul>
        </nav>
        </>
    )
}