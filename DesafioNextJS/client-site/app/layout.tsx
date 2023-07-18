import './globals.css'
import type { Metadata } from 'next'
import { Inter } from 'next/font/google'
import Link from 'next/link'

const inter = Inter({ subsets: ['latin'] })

export const metadata: Metadata = {
  title: 'Porta do Cliente',
  description: 'Gerenciador de Categorias',
}

export default function RootLayout({
  children,
}: {
  children: React.ReactNode
}) {
  return (
    <html lang="en">
      <body className={inter.className}>

        <h1>Sistema: Gestão de Clientes</h1>
        <nav>
          <ul>
            <li>
              <Link href="/">HOME</Link>
            </li>
            <li>
              <Link href="/categorias">CATEGORIA CLIENTE</Link>
            </li>
          </ul>
        </nav>
        <hr />
        {children}</body>
    </html>
  )
}
