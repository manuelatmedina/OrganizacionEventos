import React from "react";
import {
  Navbar,
  NavbarBrand,
  NavbarContent,
  NavbarItem,
  Link,
} from "@nextui-org/react";
import { Logo_Component } from "./";

export const Navbar_Component = () => {
  return (
    <Navbar>
      <NavbarBrand>
        <Logo_Component />
        <p className="font-bold text-inherit">Organizador de Eventos</p>
      </NavbarBrand>
      <NavbarContent className="hidden sm:flex gap-4" justify="center">
        <NavbarItem>
          <Link color="foreground" href="#">
            Empleados
          </Link>
        </NavbarItem>
        <NavbarItem isActive>
          <Link href="#" aria-current="page">
            Contratos
          </Link>
        </NavbarItem>
        <NavbarItem>
          <Link color="foreground" href="#">
            Servicios
          </Link>
        </NavbarItem>
        <NavbarItem>
          <Link color="foreground" href="#">
            Eventos
          </Link>
        </NavbarItem>
      </NavbarContent>
    </Navbar>
  );
};
